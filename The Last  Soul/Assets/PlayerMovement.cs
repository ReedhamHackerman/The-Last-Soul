using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    GameObject player;
    private Rigidbody2D playerRBody;
    public float playerMoveSpeed;
    public float playerJump = 20;
    public bool isGrounded = false;
    public bool isMoveSpeedPowerOn = false;
    public int poweupMoveIncrese;
    
    float moveSpeedPowerTimer = 0;
    void Start()
    {
        player = gameObject;
        playerRBody = player.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true )
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
    }

    void PlayerMovementASD()
    {

        float xmove = Input.GetAxisRaw("Horizontal");
        float zmove = Input.GetAxisRaw("Vertical");

        playerRBody.velocity = new Vector2(xmove * playerMoveSpeed * Time.deltaTime, playerRBody.velocity.y);


    }

    void Jump()
    {
        
        playerRBody.velocity = Vector2.up * playerJump;
        isGrounded = false;
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

