using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer masterAudMixer;
    public AudioMixer musicAudMixer;
    public AudioMixer SFXAudMixer;

    public void SetMasterVolume(float masterVolume)
    {
        print(masterVolume);
        masterAudMixer.SetFloat("MasterVol", masterVolume);
    }

    public void SetMusicVolume(float musicVolume)
    {
        print(musicVolume);
        musicAudMixer.SetFloat("MusicVol", musicVolume);
    }

    public void SetSFXVolume(float SFXVolume)
    {
        print(SFXVolume);
        musicAudMixer.SetFloat("SFXVol", SFXVolume);
    }
}
