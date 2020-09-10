using UnityEngine;
using UnityEngine.SceneManagement;

public class MainFlow : MonoBehaviour
{

    public enum Exercise
    {
        PointCloud,
        Centroid,
        AcuteOrObtuse,
        WhichSideOfTheLine,
        PiApproximation,
        CameraMovement2D,
        LerpingOverTime,
        Rotation1,
        Rotation2,
        DelayedAutoAim,
        GridOfSquares,
        Sphere,
        Line,
        SineWave,
        BasicPerlinNoise,
        AdvancedPerlinNoise,
        MontyHallSimulation,
        Bowling,
        Shooting,
        Jumping,
    }

    public Exercise exercise;

    void Start()
    {
        SceneManager.LoadScene(exercise.ToString());
    }



}
