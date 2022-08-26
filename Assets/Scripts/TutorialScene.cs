using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TutorialScene : MonoBehaviour
{
    public InputActionReference toggleChangeScene = null;

    void Awake()
    {
        toggleChangeScene.action.started += ChangeScene;
    }

    void OnDestroy()
    {
        toggleChangeScene.action.started -= ChangeScene;
    }

    public void ChangeScene(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(1);
    }
}
