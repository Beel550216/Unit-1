using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Boundary")
       {
            Destroy(collision.gameObject);

       }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
