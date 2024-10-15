using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    Helper helper;

    SpriteRenderer sr;
    Rigidbody2D rb;

    float dir;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        helper = gameObject.AddComponent<Helper>();

        dir = 1;

    }

    void Update()
    {
        Patrolling();

        //helper.DoRayCollisionCheck(0, -0.5f, 0.5f);
    }

    void Patrolling()
    {
        rb.velocity = new Vector2(dir, 0);

        if(helper.DoRayCollisionCheck(-0.3f, -0.5f, 0.3f) == false)
        {
            if(dir < 0)
            {
                dir = 1;
                sr.flipX = false;

            }
        }

        if (helper.DoRayCollisionCheck(0.3f, -0.5f, 0.3f) == false)
        {
            if (dir > 0)
            {
                dir = -1;
                sr.flipX = true;

            }
        }
    }



}
