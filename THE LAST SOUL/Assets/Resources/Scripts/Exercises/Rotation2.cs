using UnityEngine;

public class Rotation2 : MonoBehaviour
{

    void Update()
    {

        SetRotation();
    }

    //This function sets the rotation of the transform such that it points at the mouse cursor
    void SetRotation()
    {
        Vector3 mousePosition;

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        transform.right = mousePosition - transform.position;
    }
}
