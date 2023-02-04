using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class CheckWin : MonoBehaviour
    {
        private Roots root;
        public int nextLevel;

        private void Awake()
        {
            root = GetComponent<Roots>();
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

            for (int i = 0; i < root.Waters.Count; i++)
            {
                if (!root.Waters[i].activated)
                {
                    isWon = false;
                }
            }

            return isWon;
        }
    }

}
