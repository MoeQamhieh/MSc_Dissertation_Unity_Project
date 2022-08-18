using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class PubEnabler : MonoBehaviour
    {
        public PoseStampedPublisher posePublisher;

        // Start is called before the first frame update
        void Start()
        {
            posePublisher.enabled = false;
            StartCoroutine(SwitchStatus());
        }

        IEnumerator SwitchStatus()
        {
            yield return new WaitForSeconds(20);
            posePublisher.enabled  = !posePublisher.enabled;
        }
    }

}
