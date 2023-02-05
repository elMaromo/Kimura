using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
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
            volumen = PlayerPrefs.GetFloat("Volumen");
        }


        public void PlaySound(int posSound)
        {
            if (posSound >= 10)
                soundEffects[posSound].volume = volumen * 0.5f;

            soundEffects[posSound].Play();
        }
        public void StopSound()
        {
            for (int i = 10; i < soundEffects.Length; i++)
            {
                soundEffects[i].Stop();
            }
        }
        public void yesLoop()
        {
            for (int i = 10; i < soundEffects.Length; i++)
            {
                soundEffects[i].loop = true;
            }
        }

    }
}

