using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public GameObject player;
    private Rigidbody2D playerRBody;
    public float playerMoveSpeed;
    public float playerJump = 20;
    
    public bool isMoveSpeedPowerOn = false;
    public int poweupMoveIncrese;
    public bool doubleJump;
    float moveSpeedPowerTimer = 0;
    public Transform feet;
    public LayerMask groundLayers;
    void Start()
    {
        player = gameObject;
        playerRBody = player.GetComponent<Rigidbody2D>(); 
    }
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Space) && isGrounded())
            Jump();

        PlayerMovementASD();       

        if (isMoveSpeedPowerOn)
        {
            moveSpeedPowerTimer += Time.deltaTime;

            if (moveSpeedPowerTimer > 3)
            {
                moveSpeedPowerTimer = 0;
                isMoveSpeedPowerOn = false;
                playerMoveSpeed = playerMoveSpeed - poweupMoveIncrese ;
            }
        }

        if (gameObject.tag == "MovingPlatform")
        {
            void OnCollisionEnter2D(Collision2D col)
            {
                // if (col.gameObject.name.Equals("Cloud"))

                this.transform.parent = col.transform;
            }

            void OnCollisionExit2D(Collision2D col)
            {
                //if (col.gameObject.name.Equals("Cloud"))

                this.transform.parent = null;
            }
        }
       




    }

    void PlayerMovementASD()
    {
        float xmove = Input.GetAxisRaw("Horizontal");       
        playerRBody.velocity = new Vector2(xmove * playerMoveSpeed , playerRBody.velocity.y);
    }

    void Jump()
    {  
        playerRBody.velocity = Vector2.up * playerJump;       
    }

    public bool isGrounded ()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if(groundCheck != null)
        {
            return true;
        }
        else
            return false;
    }
    public void SetSpeedHigh()
    {
        isMoveSpeedPowerOn = true;
        playerMoveSpeed =  poweupMoveIncrese + playerMoveSpeed;
    }
}









/*void ProcessInput()
{
    if (Input.GetKeyDown(KeyCode.Space))
        playerRBody.AddForce(new Vector2(0, playerMoveSpeed), ForceMode2D.Impulse);


    if (Input.GetKeyDown(KeyCode.A))
        playerRBody.AddForce(new Vector2(-playerMoveSpeed, 0), ForceMode2D.Impulse);
    if (Input.GetKeyDown(KeyCode.D))
        playerRBody.AddForce(new Vector2(playerMoveSpeed, 0), ForceMode2D.Impulse);



Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += playerMoveSpeed * Time.deltaTime * movement;

}*/


/*if (Input.GetKey(KeyCode.A))
        playerRBody.AddForce(new Vector2(-playerMoveSpeed * Time.fixedDeltaTime, 0), ForceMode2D.Force);
    if (Input.GetKey(KeyCode.D))
        playerRBody.AddForce(new Vector2(playerMoveSpeed * Time.fixedDeltaTime, 0), ForceMode2D.Force);*/

/* if (Input.GetKeyDown(KeyCode.A))
         playerRBody.AddForce(new Vector2(-playerMoveSpeed * 0.01f, 0), ForceMode2D.Impulse);
     if (Input.GetKeyDown(KeyCode.D))
         playerRBody.AddForce(new Vector2(playerMoveSpeed* 0.01f, 0), ForceMode2D.Impulse);*/
/*if (Input.GetKey(KeyCode.A))
    playerRBody.velocity = new Vector2(-playerMoveSpeed * Time.fixedDeltaTime, playerRBody.velocity.y);

if (Input.GetKey(KeyCode.D))
    playerRBody.velocity = new Vector2(playerMoveSpeed * Time.fixedDeltaTime, playerRBody.velocity.y);*/

