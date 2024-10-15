using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : MonoBehaviour
{
    public Animator animator;

    private bool open = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKey("a"))                            //or e?
        {
            animator.SetBool("Open", true);
            open = true;
        }
        if (open == true)
        {
            animator.SetBool("Close", true);

        }
    }
        void Start()
        {
            //animator.SetBool("Open", false);
        }

    public void Destroy()
    {
        Destroy(gameObject);

        //Score.instance.AddMorePoints();
    }



    void Update()
    {

    }
}
