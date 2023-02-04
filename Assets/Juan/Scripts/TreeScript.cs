using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class TreeScript : MonoBehaviour
    {
        public Casilla tipe;

        private Roots roots;

        public void initRoots(Roots iRoots)
        {
            roots = iRoots;
        }


        private void OnMouseDown()
        {
            roots.Expand(tipe);
        }
    }
}

