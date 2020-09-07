using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField] private int dotsNumber;

    [SerializeField] GameObject dotsParent;

    [SerializeField] GameObject dotPrefab;

    [SerializeField] private float dotSpacing;

     Transform[] dotsList;

     Vector2 pos;

     private Color color;
     float timeStamp;

    
    // Start is called before the first frame update
    void Start()
    {
        Hide();
        PrepareDots();
        
      
       
    }



    void PrepareDots()
    {
      
        dotsList = new Transform[dotsNumber];
        for (int i = 0; i < dotsNumber; i++)
        {
            dotsList[i] = Instantiate(dotPrefab, null).transform;
            dotsList[i].parent = dotsParent.transform;
           
        }
    }


    public void UpdateDots(Vector2 ballpos ,Vector2 forceApllied)
    {
        timeStamp = dotSpacing;
        for (int i = 0; i < dotsNumber; i++)
        {
            pos.x = (ballpos.x + forceApllied.x * timeStamp);
            pos.y = (ballpos.y + forceApllied.y * timeStamp)-(Physics2D.gravity.magnitude*timeStamp*timeStamp)/2f;
            dotsList[i].position = pos;
            timeStamp += dotSpacing;
        }
    }
    public void Show()
    {
        dotsParent.SetActive(true);
    }

    public void Hide()
    {
        dotsParent.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
