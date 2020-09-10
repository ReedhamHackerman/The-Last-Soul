using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public float radius;
    public float maxForce;

    private int layermaxk;

    // Start is called before the first frame update
    void Start()
    {
        layermaxk = LayerMask.GetMask("CannonBall");
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Explode();
    }


    //This function finds all the cannonballs that are within 'radius' of this object's position.
    //It then applies a force to each cannonball's rigidbody2D. The direction of the force applied
    //to each cannonball should be directly away from the center of the explosion (this object's position).
    //The magnitude of the force should be equal to maxForce if the distance between the cannonball 
    //and the explosion is 0; it should be equal to 0 if the distance between the cannonball
    //and the explosion is 'radius'; for any distance in between, the magnitude of the force should be 
    //a lerped value between maxForce and 0
    void Explode()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, radius, layermaxk);
        foreach (Collider2D collider in hitColliders)
        {
            Vector2 distanceFromBomb = collider.transform.position - transform.position;
            //Vector2 normalisedDistance = distanceFromBomb.normalized;
            float distance = Vector2.Distance(collider.transform.position, transform.position);
            collider.GetComponent<Rigidbody2D>().AddForce(distanceFromBomb * Mathf.Lerp(maxForce,0f, distance / radius), ForceMode2D.Impulse);
        }
    }

    
}
