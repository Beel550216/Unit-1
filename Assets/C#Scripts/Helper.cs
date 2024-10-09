using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{

    LayerMask groundLayerMask;
    SpriteRenderer sr;
    Rigidbody2D rb;


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




    // Update is called once per frame
    void Update()
    {
        
    }
}
