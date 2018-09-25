using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed;
    public float jumpPower;
 
    private float jumpTimeCounter;
    public float jumpTime;
   

    private Rigidbody2D rbody;
    private Collider2D myCollider;
    private Animator myAnimator;
    public GameManager theGameManager;

    public bool isJumping;
    public bool grounded;
    public LayerMask whatIsTheGround;

    // Update is called once per frame
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsTheGround);

        rbody.velocity = new Vector2(speed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rbody.velocity = new Vector2(rbody.velocity.x, jumpPower);
        }
        if (Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (jumpTimeCounter > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpPower);
                jumpTimeCounter -= Time.deltaTime;
            } else {
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        } 
        myAnimator.SetBool("Grounded", grounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            theGameManager.RestartGame();
        }
        if (collision.gameObject.tag == "Coin")
        {
            theGameManager.RestartGame();
        }
    }
}
