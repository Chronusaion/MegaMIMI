using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D myRb;
    SpriteRenderer spriteR;

    //move var
    public int moveSpeed = 0;
    public int topSpeed = 0;
    public int jumpSpeed = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRb = GetComponent<Rigidbody2D>();
        spriteR = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void FixedUpdate()
    {
        
        //Move 
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            myRb.velocity = new Vector2(moveSpeed, myRb.velocity.y);
            //animacion Run_right* and flip the sprite
            animator.Play("Player_run");
            spriteR.flipX = false;

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            myRb.velocity = new Vector2(-moveSpeed, myRb.velocity.y);
            //animacion Run_left* and flip the sprite
            animator.Play("Player_run");
            spriteR.flipX = true;

        }
        else // is not moving
        {
            //Back to idle_ despues de correr
            animator.Play("Player_idle");
            myRb.velocity = new Vector2(0, myRb.velocity.y);
        }

        
        //Jump
        if (Input.GetKey("space"))
        {

            myRb.velocity = new Vector2(myRb.velocity.x, jumpSpeed);
            // animacion jump
            animator.Play("Player_jump");
        }
    


    }
}
