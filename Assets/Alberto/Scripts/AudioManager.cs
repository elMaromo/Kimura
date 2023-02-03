using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] soundEffects;
    private float volumen;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    public void PlaySound(int posSound)
    {
        soundEffects[posSound].Play();
    }

    public void StopSounds()
    {
        for (int i = 10; i < soundEffects.Length; i++)
        {
            soundEffects[i].Stop();
        }
    }

}