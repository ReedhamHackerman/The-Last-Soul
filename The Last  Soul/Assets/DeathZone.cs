using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DeathZone : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {       
       
        loadlevel();
    }
    public void loadlevel()
{    
        SceneManager.LoadScene("DeathScreenScene");
}
   
}
