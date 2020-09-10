using UnityEngine;

public class Circle : MonoBehaviour
{

    LineRenderer lineRend;
    float radius;

    float thetaScale = 0.01f;
    int numOfPoints;

    public void Initialize(float _radius)
    {
        radius = _radius;
        lineRend = gameObject.GetComponent<LineRenderer>();
        numOfPoints = (int)(2f * Mathf.PI / thetaScale) + 1;
        lineRend.positionCount = numOfPoints;
        SetPoints();
    }

    void SetPoints()
    {
        float theta = 0;
        for (int i = 0; i < numOfPoints; i++)
        {
            float x = Mathf.Cos(theta) * radius;
            float y = Mathf.Sin(theta) * radius;
            lineRend.SetPosition(i, new Vector3(x, y, 0f));
            theta += (2f * Mathf.PI * thetaScale);
        }
    }
}
