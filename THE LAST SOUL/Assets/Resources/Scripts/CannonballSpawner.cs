using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballSpawner : MonoBehaviour
{
    Vector2 xSpawnRange = new Vector2(-8, 8);
    Vector2 ySpawnRange = new Vector2(-1, 7);
    public float timeBetweenSpawns;
    float timeSinceLastSpawn;
    GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        ballPrefab = Resources.Load<GameObject>("Prefabs/CannonBall");
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawns)
        {
            SpawnBall();
            timeSinceLastSpawn = 0;
        }
           
    }

    void SpawnBall()
    {
        Instantiate(ballPrefab, new Vector3(Random.Range(xSpawnRange.x, xSpawnRange.y), Random.Range(ySpawnRange.x, ySpawnRange.y), 0), Quaternion.identity, transform);
    }
}
