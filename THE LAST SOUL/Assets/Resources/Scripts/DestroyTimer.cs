using UnityEngine;

public class DestroyTimer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Obstacle"))
        {
            DestroyCOL();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            DestroyCOL();
        }
    }
    void DestroyCOL()
    {
        Destroy(this.gameObject);
    }
}
