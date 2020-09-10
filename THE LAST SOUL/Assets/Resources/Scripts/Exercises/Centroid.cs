using UnityEngine;

public class Centroid : MonoBehaviour
{

    public int numOfPoints;
    public float zoneSize;

    public bool wanderMode;

    Transform[] points;
    Wander[] wanderScripts;
    GameObject centroid;

    bool wanderActive;
    Vector2 wanderSpeedRange = new Vector2(.5f, 5f);
    Vector2 timeBetweenDirectionChangeRange = new Vector2(2, 10);


    void Start()
    {
        points = SpawnRandomPoints.SpawnRandomPointCloud(numOfPoints, zoneSize, transform, false);
        centroid = (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/BigRedPoint"), CalculateCentroid(), Quaternion.identity);
        SetupWanderScripts();
    }

    void SetupWanderScripts()
    {
        wanderScripts = new Wander[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            Wander w = points[i].gameObject.AddComponent<Wander>();
            w.Initialize(wanderSpeedRange, timeBetweenDirectionChangeRange);
            wanderScripts[i] = w;
        }

    }

    void Update()
    {
        if (!wanderActive && wanderMode)
        {
            wanderActive = true;
            foreach (Wander w in wanderScripts)
                w.Activate();
        }
        if (wanderActive && !wanderMode)
        {
            wanderActive = false;
            foreach (Wander w in wanderScripts)
                w.Deactivate();
        }
        if (wanderActive)
        {
            centroid.transform.position = CalculateCentroid();
        }
    }

    //this functions returns the Vector3 that lies at the average position of everything in "points"
    Vector3 CalculateCentroid()
    {
        Vector3 initialpos = new Vector3(0, 0, 0);
        for (int i = 0; i < points.Length; i++)
        {
            initialpos += points[i].position;

        }

        initialpos = initialpos / points.Length;
        return initialpos;
    }


}
