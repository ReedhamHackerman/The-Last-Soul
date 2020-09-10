using UnityEngine;

public class Movement2D : MonoBehaviour
{

    public float movementSpeed = 10;

    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.W))
            MoveUp();
        if (Input.GetKey(KeyCode.S))
            MoveDown();
        if (Input.GetKey(KeyCode.A))
            MoveLeft();
        if (Input.GetKey(KeyCode.D))
            MoveRight();

    }

    void MoveUp()
    {
        transform.position += (Vector3)(Vector2.up * movementSpeed * Time.deltaTime);
    }

    void MoveDown()
    {
        transform.position += (Vector3)(Vector2.down * movementSpeed * Time.deltaTime);
    }

    void MoveLeft()
    {
        transform.position += (Vector3)(Vector2.left * movementSpeed * Time.deltaTime);
    }

    void MoveRight()
    {
        transform.position += (Vector3)(Vector2.right * movementSpeed * Time.deltaTime);
    }
}
