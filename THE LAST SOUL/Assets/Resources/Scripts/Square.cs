using UnityEngine;

public class Square : MonoBehaviour
{

    LineRenderer lineRend;
    float size;

    public void Initialize(float _size)
    {
        lineRend = gameObject.GetComponent<LineRenderer>();
        size = _size;
        lineRend.positionCount = 5;
        SetPoints();
    }

    void SetPoints()
    {
        lineRend.SetPosition(0, new Vector3(-size / 2, size / 2, 0));
        lineRend.SetPosition(1, new Vector3(size / 2, size / 2, 0));
        lineRend.SetPosition(2, new Vector3(size / 2, -size / 2, 0));
        lineRend.SetPosition(3, new Vector3(-size / 2, -size / 2, 0));
        lineRend.SetPosition(4, new Vector3(-size / 2, size / 2, 0));
    }
}
