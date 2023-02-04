using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public int posX, posY;
    public GameObject rootGrid;
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
