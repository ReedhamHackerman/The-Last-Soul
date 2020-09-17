using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(270, 60, 50, 30), "Restart"))
        {
            SceneManager.LoadScene("FirstStage");
            
        }
        GUI.color = Color.black;
        GUI.Label(new Rect(100 , 100, 100, 200), "Game Over ! Wanna Continue ? Press Restart");
    }
}