using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(270, 60, 50, 30), "Restart"))
        {
            SceneManager.LoadScene(4);

        }
        GUI.color = Color.black;
        GUI.Label(new Rect(100, 100, 100, 200), "Game Over ! Wanna Continue ? Press Restart");
    }
}
