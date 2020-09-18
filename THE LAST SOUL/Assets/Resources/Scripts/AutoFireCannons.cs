using UnityEngine;

public class AutoFireCannons : MonoBehaviour
{

    public Transform target;
    public float targetRange;
    public float fireForce;
    public Vector2 timeBetweenShotsRange;

    public Transform firePoint;
    public Transform barrel;

    float timeBetweenShots;
    GameObject cannonBallPrefab;

    bool onCooldown;
    float cooldownCounter;

    public GameObject parent;

    void Start()
    {
        timeBetweenShots = Random.Range(timeBetweenShotsRange.x, timeBetweenShotsRange.y);
        cannonBallPrefab = Resources.Load<GameObject>("Prefabs/CannonBallL");
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
        Vector2 forceVector = barrel.right * fireForce;
        ball.GetComponent<Rigidbody2D>().AddForce(forceVector, ForceMode2D.Impulse);
        onCooldown = true;
    }
}
