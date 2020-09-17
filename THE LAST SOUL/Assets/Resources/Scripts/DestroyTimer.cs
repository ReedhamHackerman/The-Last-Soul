using UnityEngine;

public class DestroyTimer : MonoBehaviour
{

    public float timer = 1f;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag.Equals("Obstacle"))
    //    {
    //        DestroyCOL();
    //    }

    //}
    private void Update()
    {
        timer -= 1 * Time.deltaTime;
        CheckTimer();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Unfriendly"))
        {
            DestroyCOL();
        }
        
         
    }
    void CheckTimer()
    {
        if (timer <= 0)
            Destroy(this.gameObject);
    }
    void DestroyCOL()
    {
        Destroy(this.gameObject);
    }
}
