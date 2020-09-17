using UnityEngine;

public class AutoFireLeft : MonoBehaviour
{

    public Transform target;
    public float targetRange;
    public float fireForce;
    public Vector2 timeBetweenShotsRange;

    public Transform firePoint;
    public Transform barrel;

    float timeBetweenShots;
    public GameObject cannonBallPrefab;
    public bool left;
    bool onCooldown;
    float cooldownCounter;
    private int side ;
    public GameObject parent;
    void Start()
    {
        timeBetweenShots = Random.Range(timeBetweenShotsRange.x, timeBetweenShotsRange.y);
        // cannonBallPrefab = Resources.Load<GameObject>("Prefabs/Bullets");
        CheckSideOfAim();
    }

    private void CheckSideOfAim()
    {
        if (left)
        {
            side = -1;
        }
        else
        {
            side = 1;
        }
    }

    void Update()
    {
        ManageCoolDown();
        CheckToFire();
    }

    void ManageCoolDown()
    {
        if (onCooldown)
        {
            cooldownCounter += Time.deltaTime;
            if (cooldownCounter >= timeBetweenShots)
            {
                cooldownCounter = 0;
                onCooldown = false;
            }
        }
    }

    void CheckToFire()
    {
        if (!onCooldown && Vector3.SqrMagnitude(transform.position - target.position) <= Mathf.Pow(targetRange, 2))
            Fire();
    }


    void Fire()
    {
        GameObject ball = GameObject.Instantiate(cannonBallPrefab, firePoint.position, Quaternion.identity,parent.transform);
        Vector2 forceVector = side*barrel.right * fireForce;
        ball.GetComponent<Rigidbody2D>().AddForce(forceVector, ForceMode2D.Impulse);
        
        onCooldown = true;
    }
}
