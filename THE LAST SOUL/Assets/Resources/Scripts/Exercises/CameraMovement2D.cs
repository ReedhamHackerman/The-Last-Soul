using UnityEngine;

public class CameraMovement2D : MonoBehaviour
{

    public float movementSpeed = 10;

    void Update()
    {
        ProcessInput();
    }

    //This function should check for keys UpArrow, DownArrow, LeftArrow, and RightArrow being pressed,
    //and call MoveUp, MoveDown, MoveLeft, and MoveRight respectively
    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.S))
            MoveUp();
        if (Input.GetKey(KeyCode.W))
            MoveDown();
        if (Input.GetKey(KeyCode.D))
            MoveLeft();
        if (Input.GetKey(KeyCode.A))
            MoveRight();
    }

    //This function should move the transform in the positive y direction by "movementSpeed" units scaled by dt
    void MoveUp()
    {

        transform.position += Vector3.up * movementSpeed * Time.deltaTime;
    }

    //This function should move the transform in the negative y direction by "movementSpeed" units scaled by dt
    void MoveDown()
    {
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;
    }

    //This function should move the transform in the negative x direction by "movementSpeed" units scaled by dt
    void MoveLeft()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    }

    //This function should move the transform in the positive x direction by "movementSpeed" units scaled by dt
    void MoveRight()
    {
        transform.position += Vector3.right * movementSpeed * Time.deltaTime;
    }

}
