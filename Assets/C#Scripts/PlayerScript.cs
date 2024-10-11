using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Helper helper;

    Rigidbody2D rb;
    SpriteRenderer sr;
    private float speed = 2.5f;
    public Animator animator;

    bool grounded, jumping;

    private void OnCollisionStay2D(Collision2D collision)
    {
        grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        helper = gameObject.AddComponent<Helper>();

        animator.SetFloat("Speed", 0);
    }


    void Update()
    {
        speed = 2.5f;
        helper.DoRayCollisionCheck(0,0,0.5f);
        

        animator.SetFloat("Speed", 0);
        MovePlayer();

        Jump();
        Falling();
        Landed();

    }

    void Jump()
    {
        if (Input.GetKeyDown("space") && grounded == true)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);

            animator.SetBool("jumpOff" , true);
            animator.SetBool("landed", false);

            jumping = true;
        }
    }

    void Falling()
    {
        if(jumping == true && grounded == false && (rb.velocity.y > 0))
        {
            animator.SetBool("falling", true);
        }
    }

    void Landed()
    {
        if(jumping && grounded && (rb.velocity.y <= 0))
        {
            jumping = false;
            animator.SetBool("jumpOff", false);
            animator.SetBool("landed", true);
            animator.SetBool("falling", false);
        }
    }









    void MovePlayer()
    {
        


        if (Input.GetKey("left") == true)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            animator.SetFloat("Speed", 1);
            sr.flipX = true;

            print("player moving left");
        }
        if (Input.GetKey("right") == true)
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
            animator.SetFloat("Speed", 1);
            sr.flipX = false;
            print("player moving right");
        }




    }
}
