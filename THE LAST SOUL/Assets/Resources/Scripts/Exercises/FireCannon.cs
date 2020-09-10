using UnityEngine;

public class FireCannon : MonoBehaviour
{

    public float fireForce;
    public Transform firePoint;
    public Transform fireDirectionPoint;
    public GameObject cannonBallPrefab;
   
    void Start()
    {
        
    }

    void Update()
    {
        ProcessInput();
       
    }

    void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();
    }

    //this function instantiates a cannonball at the position of "firePoint", and then launches 
    //it by adding a force to its rigidbody whose magnitude is equal to "fireForce"
    void Fire()
    {

        GameObject cannon = Instantiate(cannonBallPrefab, firePoint.position, Quaternion.identity);
        cannon.GetComponent<Rigidbody2D>().AddForce((fireDirectionPoint.position-firePoint.position) * fireForce, ForceMode2D.Impulse);
    }

  
}
