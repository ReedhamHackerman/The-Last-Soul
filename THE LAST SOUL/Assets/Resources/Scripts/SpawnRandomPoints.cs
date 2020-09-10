using UnityEngine;

public static class SpawnRandomPoints
{


    public static Transform[] SpawnRandomPointCloud(int numOfPoints, float zoneSize, Transform parent, bool twoD)
    {
        Transform[] points = new Transform[numOfPoints];
        for (int i = 0; i < numOfPoints; i++)
        {
            Transform t = SpawnRandomPoint(zoneSize, parent, twoD).transform;
            points[i] = t;
        }
        return points;
    }

    public static Vector3 RandomVector(float range, bool twoD)
    {
        if (twoD)
            return new Vector3(Random.Range(-range / 2, range / 2), Random.Range(-range / 2, range / 2), 0);
        else
            return new Vector3(Random.Range(-range / 2, range / 2), Random.Range(-range / 2, range / 2), Random.Range(-range / 2, range / 2));
    }

    public static GameObject SpawnRandomPoint(float range, bool twoD)
    {
        return (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/Point"), RandomVector(range, twoD), Quaternion.identity);
    }

    public static GameObject SpawnRandomPoint(float range, Transform parent, bool twoD)
    {
        return (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/Point"), RandomVector(range, twoD), Quaternion.identity, parent);
    }


}
