using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void Start()
    {
        audioSource.clip = audioClip;

    }

    public void playClip()
    {
        audioSource.Play();
    }
}