using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    [Header ("______AudioSource______")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSouce;
    [SerializeField] AudioSource weatherSource;

    [Header ("______AudioClips______")]
    public AudioClip background;
    public AudioClip rain;
    public AudioClip sfx3;
    public AudioClip sfx4;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
        
        weatherSource.clip = rain;
        weatherSource.Play();
    }












    /*public void Button1()
    {
        audio.clip = sfx1;
        audio.Play();
    }*/

}
