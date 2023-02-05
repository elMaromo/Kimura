using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class TreeScript : MonoBehaviour
    {
        public Casilla tipe;
        public float sizeIncrease;

        private Roots roots;
        private SpriteRenderer sp;

        public void Awake()
        {
            sp = GetComponent<SpriteRenderer>();
        }

        public void initRoots(Roots iRoots)
        {
            roots = iRoots;
        }


        private void OnMouseDown()
        {
            roots.Expand(tipe);
        }

        public void OnMouseEnter()
        {
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
        }

        public void OnMouseExit()
        {
            transform.localScale -= new Vector3(sizeIncrease, sizeIncrease, 0);
        }
    }
}

