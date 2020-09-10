using UnityEngine;

public class RespawnCollider : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject player;
    Rigidbody2D playerRb;

    // Use this for initialization
    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
            RespawnPlayer();
    }

    void RespawnPlayer()
    {
        player.transform.position = spawnPoint.position;
        player.transform.rotation = Quaternion.identity;
        playerRb.velocity = Vector2.zero;
        playerRb.angularVelocity = 0;
    }
}
