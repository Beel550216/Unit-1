using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemstones : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    public AudioClip gemstone;

    private void OnTriggerEnter2D( Collider2D collision)
    {
        Destroy(gameObject);
        print("You have collected a gemstone!");
    
        if(gameObject.tag == "gem+")
        {
            Score.instance.AddMorePoints();
        }
        else
        {
            Score.instance.AddPoints();
        }

        SFXSource.clip = gemstone;
        SFXSource.Play();
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
