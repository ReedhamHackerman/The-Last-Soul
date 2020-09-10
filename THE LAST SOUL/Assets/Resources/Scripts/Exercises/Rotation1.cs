using UnityEngine;

public class Rotation1 : MonoBehaviour
{


    public float rotationSpeed = 90;

    void Update()
    {
        ProcessInput();
    }

    //this function should check whether A is being pressed, and if so call rotate counterClockwise
    //and it should check if D is being pressed, and if so call rotate clockwise
    void ProcessInput()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            RotateClockwise();
        if (Input.GetKey(KeyCode.DownArrow))
            RotateCounterClockwise();

    }

    //this function should rotate this transform clockwise by "rotationSpeed" degrees scaled by dt
    void RotateClockwise()
    {

        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    //this function should rotate this transform counter-clockwise by "rotationSpeed" degrees scaled by dt
    void RotateCounterClockwise()
    {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }
}
