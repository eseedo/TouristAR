using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;

    public AudioClip peopleAudio;
    private AudioSource audioSource;

    public int ClipToPlay
    {
        set
        {
            audioSource.clip = audioClips[value];
            audioSource.Play();
        }
    }

    public AudioClip[] audioClips;

    private void Awake()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        instance = null;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPeopleAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.clip = null;
            
        }
        else
        {
            audioSource.clip = peopleAudio;
            audioSource.Play();
        }
    }
}