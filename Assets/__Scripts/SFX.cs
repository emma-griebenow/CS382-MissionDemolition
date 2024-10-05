using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip slingshot;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

