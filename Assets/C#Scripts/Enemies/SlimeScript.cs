using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    Helper helper;
    PlayerScript player;
    SpriteRenderer sr;
    Rigidbody2D rb;

    [SerializeField] AudioSource SFXSource;
    public AudioClip enemy;

    private float health = 3;

    void Start()
    {
        helper = gameObject.AddComponent<Helper>();

        player = gameObject.AddComponent<PlayerScript>();

        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //player.Damage();

        if (Input.GetKey("a"))
        {
            //health = health--;

           // if (health == 0)
          
            Destroy(gameObject);
         

            SFXSource.clip = enemy;
            SFXSource.Play();

        }




        void Update()
        {
            helper.DoRayCollisionCheck(-0.5f, -0.5f, 0.5f);
            helper.DoRayCollisionCheck(0.5f, -0.5f, 0.5f);
        }
    }
}
