using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class TreeScript : MonoBehaviour
    {
        public int posX, posY;
        public GameObject rootGrid;
        public Casilla tipe;

        private Roots roots;

        public void setPos()
        {

        }


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

