using UnityEngine;

public class TriggerTarget : MonoBehaviour
{

    public Collider2D triggeringColi;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col == triggeringColi)
            Debug.Log("You win!");
    }


}
