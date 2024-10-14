using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{

    LayerMask groundLayerMask;
    SpriteRenderer sr;
    Rigidbody2D rb;

    public Animator animator;
    public int health = 3;


    // Start is called before the first frame update
    void Start()
    {
        groundLayerMask = LayerMask.GetMask("ground");
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }

    public bool DoRayCollisionCheck(float xoffs, float yoffs, float rayLength)
    {
        //float rayLength = 0.5f;
        bool hitSomething = false;

        Vector3 offset = new Vector3(xoffs, yoffs, 0);
        
        

        RaycastHit2D hit;

        hit = Physics2D.Raycast(transform.position + offset, -Vector2.up, rayLength, groundLayerMask);

        Color hitColor = Color.white;

       if(hit.collider != null)
       {
            hitSomething = true;
            hitColor = Color.green;
            print("player collided with Ground Layer");
       }

        Debug.DrawRay(transform.position + offset, -Vector3.up * rayLength, hitColor);

        return hitSomething;

    }


    private void OnCollisionEnter2D( Collision2D collision)
    {
        if (gameObject.tag != "Player")
        {
            if(gameObject.tag == "Slime" && Input.GetKey("a"))
            {
                animator.SetBool("attacked", true);
                animator.SetBool("Walk", false);
                Destroy(gameObject);


               // health = health--;

              //  if(health == 0)
             //   {
               //     Destroy(gameObject);
                //}
            }
            else if (Input.GetKey("a"))
            {
                Destroy(gameObject);

            }

            
        }
    
    }


    // Update is called once per frame
    void Update()
    {
        animator.SetBool("attacked", false);
        //animator.SetBool("Walk", true);
    }
}
