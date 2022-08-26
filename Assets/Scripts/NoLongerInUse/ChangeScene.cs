using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject transformHandler;

    void Awake()
    {
        transformHandler = GameObject.Find("TransformHandler");
    }

    public void MoveToScene(int sceneID)
    {
        transformHandler.GetComponent<PositionSaving>().lastPosition = GameObject.Find("XR Origin").transform.position;
        SceneManager.LoadScene(sceneID);
    }

    public void BackToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
