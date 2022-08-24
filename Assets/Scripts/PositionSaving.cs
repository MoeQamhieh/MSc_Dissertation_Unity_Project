using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSaving : MonoBehaviour
{
    public GameObject Origin;
    public Vector3 lastPosition;

    void Awake() 
    {
        Origin = GameObject.Find("XR Origin");
        lastPosition = Origin.transform.position;
        DontDestroyOnLoad(gameObject);
    }

}
