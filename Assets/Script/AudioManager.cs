using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;
    Player_Movement playerMovement;

    public AudioClip backgroundMusic;
    public AudioClip skillOneSFX;
    public AudioClip skillTwoSFX;
    public AudioClip skillThreeSFX;
    public AudioClip walkingSFX;

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }


    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}
