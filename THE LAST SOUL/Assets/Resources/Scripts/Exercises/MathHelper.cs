using UnityEngine;

public static class MathHelper
{

    public static bool Cointoss()
    {
        return OneInChance(2);
    }

    public static bool OneInChance(int n)
    {
        return Random.Range(0, n) == 0;
    }


    public static float Random0to1()
    {
        return Random.Range(0, 1f);
    }


    //returns true if "f1" and "f2" are within "tolerance" of each other
    public static bool EqualityCheck(float f1, float f2, float tolerance)
    {
        return false; //temp
    }

    //returns a vector pointing in the direction of "v1" to "v2", with a length of "length"
    public static Vector3 ScaledDirection(Vector3 v1, Vector3 v2, float length)
    {
        return Vector3.zero; //temp
    }

    //returns the angle (in degrees) between "v1" and 'v2"
    public static float AngleBetweenVectors(Vector2 v1, Vector2 v2)
    {
        return 0; //temp
    }

    //returns a float between -1 and 1 that indicates how parallel "v1" and "v2" are
    public static float MeasureParallelism(Vector3 v1, Vector2 v2)
    {
        return 0; //temp
    }
}
