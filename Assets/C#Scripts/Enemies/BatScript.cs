using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatScript : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;

    private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(+speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}