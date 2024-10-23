using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    [Header ("______AudioSource______")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource weatherSource;
    [SerializeField] AudioSource windSource;


    [Header ("______AudioClips______")]
    public AudioClip background;
    public AudioClip rain;
    public AudioClip wind;
    public AudioClip sword;
    public AudioClip sword2;
    public AudioClip footsteps;
    public AudioClip footsteps2;
    public AudioClip jump;
    public AudioClip mushroom;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
        
        weatherSource.clip = rain;
        weatherSource.Play();

        //groundLayerMask = LayerMask.GetMask("ground");
        //bridgeLayerMask = LayerMask.GetMask("bridge");
    }

    public void Hit()
    {
        SFXSource.clip = sword;
        SFXSource.Play();
    }

    public void Slash()
    {
        SFXSource.clip = sword2;
        SFXSource.Play();
    }

    public void Jump2()
    {
        SFXSource.clip = jump;
        SFXSource.Play();
    }

    public void Footsteps()
    {
        

        SFXSource.clip = footsteps;
        SFXSource.Play();
        
        
    }
    
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        SFXSource.Stop();
        
        if (other.gameObject.CompareTag("bridge"))
        {
           SFXSource.clip = footsteps2;
           SFXSource.Play();
           print("BRIDGE");
        }
       
    }*/
        


    /*public void Button1()
    {
        audio.clip = sfx1;
        audio.Play();
    }*/

}
