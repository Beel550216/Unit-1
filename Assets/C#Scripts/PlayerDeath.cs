using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Animator animator;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bat")
        {
            Destroy(collision.gameObject);
            //animator.SetBool("Dead", true);


        }
    }

}
    // Start is called before the first frame update


 

