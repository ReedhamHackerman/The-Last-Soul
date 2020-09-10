using UnityEngine;

public class BasicPerlinNoise : MonoBehaviour
{

    static float shift = .51f;

    public LineRenderer line;

    public float xLength = 100;
    public float vertexSpacing = .1f;
    public float amplitude = 1;
    public float waveLength = 1;

    int xOffset = 1000;
    public int seed = 100;


    void Start()
    {

        SetLineVertices();
    }

    //this function sets up the LineRenderer "line" so that its vertices form a perlin noise surface,
    //extending for "xLength", with vertices spaced by "vertexSpacing"
    void SetLineVertices()
    {

    }


}
