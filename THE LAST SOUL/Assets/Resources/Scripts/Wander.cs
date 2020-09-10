using UnityEngine;

public class Wander : MonoBehaviour
{


    Vector2 speedRange;
    Vector2 timeTilDirectionChangeRange;

    bool active;
    Vector3 currentWanderDirection;
    float timeSinceLastChange;
    float nextChangeTime;
    float currentSpeed;


    void Start()
    {

    }

    public void Initialize(Vector2 _speedRange, Vector2 _timeTilDirectionChangeRange)
    {
        speedRange = _speedRange;
        timeTilDirectionChangeRange = _timeTilDirectionChangeRange;
        currentSpeed = Random.Range(speedRange.x, speedRange.y);
        currentWanderDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        nextChangeTime = Random.Range(timeTilDirectionChangeRange.x, timeTilDirectionChangeRange.y);
    }
    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            transform.position += currentWanderDirection * currentSpeed * Time.deltaTime;
            timeSinceLastChange += Time.deltaTime;
            if (timeSinceLastChange >= nextChangeTime)
            {
                timeSinceLastChange = 0;
                nextChangeTime = Random.Range(timeTilDirectionChangeRange.x, timeTilDirectionChangeRange.y);
                currentWanderDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
                currentSpeed = Random.Range(speedRange.x, speedRange.y);
            }
        }

    }

    public void Activate()
    {
        active = true;
    }
    public void Deactivate()
    {
        active = false;
    }
}
