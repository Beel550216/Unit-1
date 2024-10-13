using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    Helper helper;

    public GameObject player;
    public Animator animator;
    private float ex;
    private float px;
    SpriteRenderer sr;
    Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("Walk", false);

        helper = gameObject.AddComponent<Helper>();

    }

    // Update is called once per frame
    void Update()
    {
        ex = transform.position.x;
        px = player.transform.position.x;
        float speed = 1f;

        if( ex < px)
        {
            animator.SetBool("Walk", true);

            sr.flipX = true;

            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }  
        else
        {
            animator.SetBool("Walk", true);

            sr.flipX = false;
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

    }
}
