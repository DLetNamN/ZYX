using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SwitchMusic : MonoBehaviour
{
    AudioSource thisAudioSource;

    public AudioClip CloneArmySong;
    public AudioClip DroidArmySong;

    private void Start()
    {
        thisAudioSource = GetComponent<AudioSource>();
        thisAudioSource.clip = CloneArmySong;
        thisAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        SwitchSoundtrack();
    }

    void SwitchSoundtrack()
    {
        if (thisAudioSource.clip == CloneArmySong)
        {
            if (!thisAudioSource.isPlaying)
            {
                thisAudioSource.clip = DroidArmySong;
                thisAudioSource.Play();
            }
        }
        else if (thisAudioSource.clip == DroidArmySong)
        {
            if (!thisAudioSource.isPlaying)
            {
                thisAudioSource.clip = CloneArmySong;
                thisAudioSource.Play();
            }
        }
    }
}
