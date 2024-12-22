using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicandSounds : MonoBehaviour
{
    AudioSource audioSource;
    public bool currentlyPlaying;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonFunctions.musicOn && !currentlyPlaying)
        {
            audioSource.Play();
            currentlyPlaying = true;
        }
        else if (!ButtonFunctions.musicOn && currentlyPlaying)
        {
            audioSource.Stop();
            currentlyPlaying = false;
        }
        

    }
}
