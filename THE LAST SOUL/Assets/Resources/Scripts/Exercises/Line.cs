using UnityEngine;

public class Line : MonoBehaviour
{

    Vector3 startPoint = new Vector3(3, 4, 0);
    Vector3 endPoint = new Vector3(11, -4, 2);
    float pointSpacing = .2f;

    GameObject pointPrefab;
    private GameObject secondParent;
    private GameObject parent;

    void Start()
    {
        parent = new GameObject("All The Points Are here");
        secondParent = new GameObject("This Is second Parent");
        pointPrefab = Resources.Load<GameObject>("Prefabs/Point");
        SpawnPointsInLine();
    }

    //this function spawns a line of points, spaced by "pointSpacing", that extends from "startPoint" to "endPoint"
    void SpawnPointsInLine()
    {

        Vector3 newvector = endPoint - startPoint;
        float lengthofNew = newvector.magnitude;
        Vector3 unitVector = newvector.normalized;
        // for (float i = 0; i < lengthofNew; i += pointSpacing)
        // {
        //
        //     Instantiate(pointPrefab, unitVector*i, Quaternion.identity, parent.transform);
        // }

        Vector3 currentPos = startPoint;
        while (currentPos != endPoint)
        {
            Instantiate(pointPrefab, currentPos, Quaternion.identity, secondParent.transform);
            currentPos = Vector3.MoveTowards(currentPos, endPoint, 0.2f);
        }

    }

}
