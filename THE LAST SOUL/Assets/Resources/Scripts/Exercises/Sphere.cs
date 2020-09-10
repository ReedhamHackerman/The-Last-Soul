using UnityEngine;

public class Sphere : MonoBehaviour
{

    float radius = 5;
    float pointSpacing = .5f;
    GameObject pointPrefab;


    void Start()
    {
        pointPrefab = Resources.Load<GameObject>("Prefabs/Point");
        SpawnSphereOfPoints();
    }

    //This function spawns a grid of points spaced by "pointSpacing" in the shape of a sphere of radius "radius"
    void SpawnSphereOfPoints()
    {

    }
}
