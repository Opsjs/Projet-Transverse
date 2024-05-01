using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStarter : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource= GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.loop=true;
        audioSource.Play();
            
    }

}
