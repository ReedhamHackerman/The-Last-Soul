using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
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
}
