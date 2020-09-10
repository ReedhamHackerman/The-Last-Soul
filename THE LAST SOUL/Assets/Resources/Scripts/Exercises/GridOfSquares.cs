using UnityEngine;

public class GridOfSquares : MonoBehaviour
{

    GameObject squarePrefab;

    int gridWidth = 10;
    int gridHeight = 6;

    float xSpacing = 1f;
    float ySpacing = 1f;

    float gridXPos = 0;
    float gridYPos = 0;

    void Start()
    {
        squarePrefab = (GameObject)Resources.Load("Prefabs/Square");
        SpawnSquares();
    }

    //this function spawns a series of "squarePrefab" objects that are arranged in a "gridWidth" by "gridHeight" grid
    void SpawnSquares()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(squarePrefab, new Vector3(i, 0, 0), Quaternion.identity);
        }
    }
}
