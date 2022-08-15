using System.Collections;
using System.Collections.Generic;
using RosSharp.RosBridgeClient;
using std_msgs = RosSharp.RosBridgeClient.MessageTypes.Std;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{

    public class ExampleSendReceive : MonoBehaviour
    {
        RosSocket rosSocket;
        string publication_id;
        string subscription_id;

        // Start is called before the first frame update, here the connection with ROS is established and the tipics are defined
        void Start()
        {
            rosSocket = new RosSocket(new RosBridgeClient.Protocols.WebSocketNetProtocol("ws://localhost:9090")); //this line does the same as the script RosConnector
            Debug.Log("Established connection with ros");

            publication_id = rosSocket.Advertise<std_msgs.String>("publication_test");

            subscription_id = rosSocket.Subscribe<std_msgs.String>("/subscription_test", SubscriptionHandler);
        }

        // Update is called once per frame
        void Update()
        {
            std_msgs.String message = new std_msgs.String
            {
                data = "Message sent from unity"    //UNITY message for ROS
            };
            rosSocket.Publish(publication_id, message);
            //Debug.Log("A message was sent to ROS");
            
        }

        private static void SubscriptionHandler(std_msgs.String message)
        {
            Debug.Log(message.data);                    //print ROS's message to unity
        }
    }
}