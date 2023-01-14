// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] sounds;

    public void UpdateAudioClip(int val)
    {
        audioSource.clip = sounds[val];
    }

    public void PlayAudioClip()
    {
        audioSource.Play();
    }
}
