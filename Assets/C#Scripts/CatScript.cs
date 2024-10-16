using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Animal interaction");

        animator.SetBool("Interact", true);

    }

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Interact", false);
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("Interact", false);
    }
}
