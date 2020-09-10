using UnityEngine;

public class AdvancedPerlinNoise : MonoBehaviour
{

    static float shift = .51f;

    public LineRenderer line;
    public EdgeCollider2D edgeCollider;

    public float xLength = 50;
    public float vertexSpacing = .05f;

    public float baseAmplitude = 1;
    public float baseWaveLength = 1;
    public int numOfOctaves = 1;
    public float lacunarity = 2;

    int xOffset = 1000;
    public int seed = 100;

    void Start()
    {
        SetLineVertices();
        SetColliderVertices();
    }

    //this function sets up the LineRenderer "line" so that its vertices form a multi-octave perlin noise surface,
    //extending for "xLength", with vertices spaced by "vertexSpacing"
    void SetLineVertices()
    {

    }

    //this function sets the vertices of "edgeCollider" equal to the vertices of "line"
    void SetColliderVertices()
    {

    }
}
