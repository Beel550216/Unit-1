using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    Helper helper;
    SpriteRenderer sr;
    Rigidbody2D rb;

    private float ehealth = 3;

    void Start()
    {
        helper = gameObject.AddComponent<Helper>();

        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKey("a"))
        {
            //ehealth = ehealth--;

            //if(ehealth == 0)   
            Destroy(gameObject);

        }




        void Update()
        {
            helper.DoRayCollisionCheck(-0.5f, -0.5f, 0.5f);
            helper.DoRayCollisionCheck(0.5f, -0.5f, 0.5f);
        }
    }
}
