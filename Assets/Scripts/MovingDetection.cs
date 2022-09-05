using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDetection : MonoBehaviour
{
    public GameObject canvas;

    public float prevPos;
    public float prevRot;

    public float pos;
    public float rot;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("MovingOverlayCanvas");
        prevPos = gameObject.transform.position.x + gameObject.transform.position.y + gameObject.transform.position.z;
        prevRot = gameObject.transform.rotation.x + gameObject.transform.rotation.y + gameObject.transform.rotation.z;
        StartCoroutine(Detect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Detect()
    {
        for(;;)
        {
            pos = gameObject.transform.position.x + gameObject.transform.position.y + gameObject.transform.position.z;
            rot = gameObject.transform.rotation.x + gameObject.transform.rotation.y + gameObject.transform.rotation.z;

            if ( ((pos - prevPos) > 0.01) || ((rot - prevRot) > 0.001) )
            {
                canvas.SetActive(true);
                Debug.Log("Hello");
            } else {
                canvas.SetActive(false);
                Debug.Log("No");
            }

            yield return new WaitForSeconds(1f);

            prevPos = pos;
            prevRot = rot;
            
        }

        
    }
}
