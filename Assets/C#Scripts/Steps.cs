using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    public AudioClip footsteps2;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SFXSource.clip = footsteps2;
            SFXSource.Play();
            SFXSource.loop = true;
            print("BRIDGE");
        }
    }

    /*private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SFXSource.loop = false;
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
