using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static AudioManager Instance;
    [SerializeField]
    private AudioSource SFX_AudioSource;
    public AudioClip correctPop_Clip;
    public AudioClip WinLevel;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Full_Volume()
    {
        audioSource.volume = 1;
        SFX_AudioSource.volume = 1;
    }

    public void Med_Volume()
    {
        audioSource.volume = 0.5f;
        SFX_AudioSource.volume = 0.5f;
    }

    public void Mute_Volume()
    {
        audioSource.volume = 0;
        SFX_AudioSource.volume = 0;
    }

    public void PlaySFX(AudioClip audioClip)
    {
        SFX_AudioSource.PlayOneShot(audioClip);
    }

}
