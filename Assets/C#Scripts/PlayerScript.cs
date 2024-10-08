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


        MovePlayer();

    }


    void Update()
    {
        helper.DoRayCollisionCheck(0, 0);

    }


    void MovePlayer()
    {
        


        if (Input.GetKey("a") || Input.GetKey("left"))
        {
           rb.velocity = new Vector2(-speed, rb.velocity.y);
            sr.flipX = true;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
            sr.flipX = false;
        }
    }
}
