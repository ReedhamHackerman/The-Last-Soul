using UnityEngine;

public class WhichSideOfTheLine : MonoBehaviour
{

    Transform A;
    Transform B;
    Transform C;

    Renderer cRend;
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
        rend.SetPosition(0, 100 * (A.position - B.position) + A.position);
        rend.SetPosition(1, -100 * (A.position - B.position) + A.position);
        cRend = C.gameObject.GetComponent<Renderer>();
        cRend.material.color = Color.red;
    }


    void Update()
    {
        CheckForInput();
        if (WhichSideOfLine(A.transform.position, B.transform.position, C.transform.position))
            cRend.material.color = Color.red;
        else
            cRend.material.color = Color.green;
    }

    void CheckForInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(0, 1, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(0, -1, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(1, 0, 0);
    }

    //returns true if "pointToTest" lies on one side of the line formed by
    //"v1" and "v2", and returns false if it lies on the other side
    bool WhichSideOfLine(Vector2 v1, Vector2 v2, Vector2 pointToTest)
    {
        return false; //temp
    }

}
