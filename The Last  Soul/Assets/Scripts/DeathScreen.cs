using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
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
        if (GUI.Button(new Rect(10, 70, 50, 30), "Restart"))
        {
            SceneManager.LoadScene("SampleScene");

        }
        
    }   
}