using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Helper helper;

    Rigidbody2D rb;
    SpriteRenderer sr;
    private float speed = 4.5f;
    public Animator animator;

    bool isGrounded;

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        helper = gameObject.AddComponent<Helper>();

    }


    void Update()
    {
        speed = 4.5f;
        helper.DoRayCollisionCheck(0, 0);

        animator.SetFloat("Speed", 0);
        MovePlayer();

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
