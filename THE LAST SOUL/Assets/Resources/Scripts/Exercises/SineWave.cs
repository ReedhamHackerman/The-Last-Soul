using UnityEngine;

public class SineWave : MonoBehaviour
{

    public float amplitude = 1;
    public float waveLength = 1;
    public int numOfOctaves = 1;
    public float lacunarity = 2;
    public LineRenderer line;

    float xLength = 20;
    float vertexSpacing = .05f;

    void Start()
    {
        SetupWave();
    }

    //This function sets up the LineRenderer "line" and sets the positions of its vertices to form a sine wave
    void SetupWave()
    {

    }


}
