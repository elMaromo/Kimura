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
        private AudioSource audi;

        public void Awake()
        {
            sp = GetComponent<SpriteRenderer>();
            audi = GetComponent<AudioSource>();
        }

        public void initRoots(Roots iRoots)
        {
            roots = iRoots;
        }


        private void OnMouseDown()
        {
            roots.Expand(tipe);
            audi.Play();
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

