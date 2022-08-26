using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public InputActionReference toggleChangeScene = null;
    public GameObject transformHandler;

    private int toGoScene = 2;

    void Awake()
    {
        transformHandler = GameObject.Find("TransformHandler");
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            toGoScene = 1;
        } else if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameObject.Find("XR Origin").transform.position = transformHandler.GetComponent<PositionSaving>().lastPosition;
        }
        
        toggleChangeScene.action.started += ChangeScene;
    }

    void OnDestroy()
    {
        toggleChangeScene.action.started -= ChangeScene;
    }

    public void ChangeScene(InputAction.CallbackContext context)
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            transformHandler.GetComponent<PositionSaving>().lastPosition = GameObject.Find("XR Origin").transform.position;
        }
        
        SceneManager.LoadScene(toGoScene);
    }
}
