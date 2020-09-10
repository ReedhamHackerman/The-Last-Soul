using UnityEngine;

public class PointCloud : MonoBehaviour
{

    public int numOfPoints;
    public float zoneSize;
    // private float distanece;


    Transform[] points;
    GameObject mainPoint;
    private float distance;
    private Vector3 hello;
    // private Vector3 initialdistance;
    // private Vector3[] distanceBetween;
    // private float[] distances;
    void Start()
    {
        mainPoint = SpawnRandomPoints.SpawnRandomPoint(zoneSize, false);
        mainPoint.transform.localScale *= 4;
        mainPoint.GetComponent<Renderer>().material.color = Color.green;
        points = SpawnRandomPoints.SpawnRandomPointCloud(numOfPoints, zoneSize, transform, false);
        if (ReturnNearestPoint() != null)
        {
            GameObject nearestPoint = ReturnNearestPoint().gameObject;
            nearestPoint.GetComponent<Renderer>().material.color = Color.red;
        }



    }


    Transform ReturnNearestPoint()
    {
        Transform closestpoint = points[0];

        for (int i = 0; i < points.Length; i++)
        {

            // initialdistance.x = points[i].localPosition.x - gameObject.transform.localPosition.x;
            // initialdistance.y = points[i].localPosition.y - gameObject.transform.localPosition.y;
            // initialdistance.z = points[i].localPosition.z - gameObject.transform.localPosition.z;
            // distanceBetween[i] = initialdistance;
            // distanece = initialdistance.x * initialdistance.x + initialdistance.y * initialdistance.y +
            //             initialdistance.z + initialdistance.z;
            // distances[i] = distanece;

            if (Vector3.SqrMagnitude(mainPoint.transform.position - points[i].position) < Vector3.SqrMagnitude(mainPoint.transform.position - closestpoint.position))
            {
                closestpoint = points[i];
            }


        }

        return closestpoint;
    }


}
