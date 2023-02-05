using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class CheckWin : MonoBehaviour
    {
        private Roots root;
        public int nextLevel;
        private AudioSource audi;

        private void Awake()
        {
            root = GetComponent<Roots>();
            audi = GetComponent<AudioSource>();
        }

        private void Update()
        {
            bool won = checkIfWin();

            if (won)
            {
                ChangeScene.instance.FadeOut(nextLevel);
            }
        }

        private bool checkIfWin()
        {
            bool isWon = true;

            if( root )
            {
                for (int i = 0; i < root.Waters.Count; i++)
                {
                    if (!root.Waters[i].activated)
                    {
                        isWon = false;
                    }
                }
            }
            else
            {
                return false;
            }

            audi.Play();

            return isWon;
        }
    }

}
