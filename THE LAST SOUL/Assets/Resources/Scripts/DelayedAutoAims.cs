using UnityEngine;

public class DelayedAutoAims : MonoBehaviour
{

    public Transform target;
    public float rotationSpeed ;

    void Update()
    {
        Rotate();
    }

    //This function calls RotateClockwise and RotateCounterClockwise depending upon which way this transform needs to rotate to point at the mouse cursor
    void Rotate()
    {
        Vector2 gunPos = transform.right;

        Vector2 targetPos = target.position - transform.position;

        float angleBetween = Vector2.SignedAngle(gunPos, targetPos);
        float AngleBetween = Vector2.Angle(gunPos, targetPos);
        if (AngleBetween < rotationSpeed * Time.deltaTime)
        {
            transform.right = targetPos;
        }
        else
        {
            if (angleBetween < 0)
            {
                RotateClockwise();
            }
            else
            {
                RotateCounterClockwise();
            }
        }



    }

    //this function should rotate this transform clockwise by "rotationSpeed" degrees scaled by dt
    void RotateClockwise()
    {

        transform.Rotate(new Vector3(0, 0, -rotationSpeed * Time.deltaTime));
    }

    //this function should rotate this transform counter-clockwise by "rotationSpeed" degrees scaled by dt
    void RotateCounterClockwise()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
    }
}
