using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSaving : MonoBehaviour
{
    //public GameObject Origin;
    public Vector3 lastPosition;

    void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);
        lastPosition = new Vector3(9.89f, 5.77f, 10.97f);
        //Origin = GameObject.Find("XR Origin");
        //lastPosition = Origin.transform.position;
    }

}
