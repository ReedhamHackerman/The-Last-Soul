using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
     public float rotationSpeed;
     public bool clockWise;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(clockWise)
        {
            RotateClockWise();
        }
       else
        {
            RotateAntiClockWise();
        }
    }
    private void RotateClockWise()
    {

        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
    private void RotateAntiClockWise()
    {

        transform.Rotate(0, 0,- rotationSpeed * Time.deltaTime);
    }

}
