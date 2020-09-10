using UnityEngine;

public class AcuteOrObtuse : MonoBehaviour
{
    public LineRenderer dynamicLine;

    Transform A;
    Transform B;
    Transform C;
    Renderer CRend;

    float sizeOfArea = 8;
    float moveSpeed = 3;


    void Start()
    {
        A = SpawnRandomPoints.SpawnRandomPoint(sizeOfArea, true).transform;
        B = SpawnRandomPoints.SpawnRandomPoint(sizeOfArea, true).transform;
        C = SpawnRandomPoints.SpawnRandomPoint(sizeOfArea, true).transform;
        A.localScale *= 2;
        B.localScale *= 2;
        C.localScale *= 3;
        LineRenderer rend = GetComponent<LineRenderer>();
        rend.SetPosition(0, A.position);
        rend.SetPosition(1, B.position);
        dynamicLine.SetPosition(0, B.position);
        dynamicLine.SetPosition(1, C.position);
        CRend = C.gameObject.GetComponent<Renderer>();
        CRend.material.color = Color.red;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(0, 1, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(0, -1, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(1, 0, 0);
        dynamicLine.SetPosition(1, C.position);
        if (Acute())
        {
            CRend.material.color = Color.red;
            dynamicLine.startColor = Color.red;
            dynamicLine.endColor = Color.red;
        }
        else
        {
            CRend.material.color = Color.green;
            dynamicLine.startColor = Color.green;
            dynamicLine.endColor = Color.green;
        }

    }

    //this function returns true if the angle ABC is acute, and false if it is obtuse
    bool Acute()
    {
        return false; //temp
    }
}
