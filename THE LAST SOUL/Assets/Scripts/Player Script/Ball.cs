using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    private State state = State.Alive;

    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public CircleCollider2D c2d;
    [HideInInspector] public Vector3 BallPos
    {
        get { return transform.position; }
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        c2d = GetComponent<CircleCollider2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Unfriendly"))
        {
            state = State.died;
            RestartScene();
        }
    }

    private void RestartScene()
    {
        
        SceneManager.LoadScene(1);
    }


    public void Push(Vector2 force)
    {
        rb.AddForce(force,ForceMode2D.Impulse);
    }

    public void ActivateRb()
    {
        rb.isKinematic = false;
    }

    public void DeactivateRb()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0f;
        rb.isKinematic = true;
    }

    

    public enum State
    {
        Alive,
        died,
        transcating
    }

}
