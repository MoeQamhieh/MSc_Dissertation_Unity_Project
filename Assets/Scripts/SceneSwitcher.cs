using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public InputActionReference toggleChangeScene = null;
    private int toGoScene = 1;

    void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            toGoScene = 0;
        }
        toggleChangeScene.action.started += ChangeScene;
    }

    void OnDestroy()
    {
        toggleChangeScene.action.started -= ChangeScene;
    }

    public void ChangeScene(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(toGoScene);
    }
}
