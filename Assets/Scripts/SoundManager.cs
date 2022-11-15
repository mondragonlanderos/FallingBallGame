using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //public Dictionary<string, AudioClip> gameMusic1 = new Dictionary<string, AudioClip>();

    public List<AudioClip> gameSounds;
    public List<AudioClip> gameMusic;
        
    public static SoundManager Instance;
    
    private AudioSource audioSource;
    private AudioSource backgroundAudioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
    }
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        PlayMenuMusic();
    }

    public void PlayMenuMusic()
    {
        audioSource.loop = true;
        //audioSource.PlayOneShot(gameMusic[0]);
        var clip = gameMusic[0];
        audioSource.clip = clip;
        audioSource.Play();
    }
    public void PlayGameMusic()
    {
        audioSource.loop = true;
        //audioSource.PlayOneShot(gameMusic[0]);
        var clip = gameMusic[1];
        audioSource.clip = clip;
        audioSource.Play();
    }
    
    
    public void PlayButtonHoveredSound()
    {
        audioSource.PlayOneShot(gameSounds[0]);
    }
    
    public void PlayButtonClickedSound()
    {
        audioSource.PlayOneShot(gameSounds[1]);
    }
    
    public void PlayPickupCollectedSound()
    {
        audioSource.PlayOneShot(gameSounds[2]);
    }
    
    public void PlayTimerExpiredSound()
    {
        audioSource.PlayOneShot(gameSounds[3]);
    }
}
