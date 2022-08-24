using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject colorHandler; 

    public void ChangeTo()
    {
        colorHandler.SetActive(true);
    }

    public void ChangeBack()
    {
        colorHandler.SetActive(false);
    }
}
