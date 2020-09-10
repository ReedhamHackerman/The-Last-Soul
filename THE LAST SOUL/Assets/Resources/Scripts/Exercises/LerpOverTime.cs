using UnityEngine;

public class LerpOverTime : MonoBehaviour
{

    public Transform endTransform;
    public float travelTime;

    Vector2 startPoint;
    Vector2 endPoint;

    float elapsedTime = 0;
    bool comingBack = false;

    void Start()
    {
        startPoint = transform.position;
        endPoint = endTransform.position;
    }

    void Update()
    {
        UpdatePosition();
    }

    //This function should set the transform's position such that it travels back and forth between "startPoint" and "endPoint",
    //taking "travelTime" seconds each time
    void UpdatePosition()
    {

    }
}
