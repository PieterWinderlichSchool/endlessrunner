using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilController : MonoBehaviour
{
    //spawn location
    private float spawnPointX = -12f;
    private float spawnPointY = 0f;

    //movement speed
    public float topSpeed = 5f;

    //force of the jump
    public float jumpForce = 800f;

    //tell sprite which way it is facing
    bool facingRight = true;

    //get reference to animator
    Animator anim;

    //grounded
    bool grounded = true;

    //in the air?
    //bool air = false;

    //transform at devil foot to see if he is on the ground
    public Transform groundCheck;

    //how big the circle is going to be when we check distance to the ground
    float groundRadius = 0.5f;

    //what layer is concidered ground
    public LayerMask whatIsGround;

    //distance to the ground

    //landingRay
    //public float distanceToGround = 0.15f;



    void Start()
    {
        anim = GetComponent<Animator>();

    }

    //physics in fixed update
    private void FixedUpdate()
    {
        //true or false. did the ground transform hit the whatIsGround with the radius
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        //tell animator that we are grounded
        anim.SetBool("Ground", grounded);

        //how fast we move up and down from rigidbody
        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

        //get move direction
        float move = Input.GetAxis("Horizontal");

        //add velocity
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(move));

        //if we face negative direction and not facing right, flip
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();



    }

    void Update()
    {
        //Input.GetKeyDown(KeyCode.W))
        if (grounded && Input.GetKeyDown(KeyCode.W) || grounded && Input.GetKeyDown(KeyCode.Space))
        {
            //not on the ground
            grounded = false;
            anim.SetTrigger("Jump");

            //add jump force to the Y-axis of the rigid body
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
        else
        {
            grounded = true;
           
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("Speed", 3);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetFloat("Speed", 6);
                topSpeed = 10f;
            }
            else
            {
                anim.SetFloat("Speed", 3);
                topSpeed = 5f;
            }
        }
        else
        {
            anim.SetFloat("Speed", 0);

        }

    }

    
    public void Respawn()
    {
        //transform.position = new Vector3(spawnPointX, spawnPointY, 0);

    }

    void Flip()
    {
        //saying we face other direction
        facingRight = !facingRight;

        //get local scale
        Vector3 theScale = transform.localScale;

        //flip on x-axis
        theScale.x *= -1;

        //apply that to local scale
        transform.localScale = theScale;
    }

   
}