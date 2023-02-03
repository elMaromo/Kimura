using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public int posX, posY;
    public GameObject rootGrid;
    public Casilla tipe;

    private Roots roots;
    private bool won;

    private void Awake()
    {
        roots = rootGrid.GetComponent<Roots>();
    }

    private void Start()
    {
        won = false;
        roots.roots[posX, posY] = tipe;
        roots.placeRoot(posX, posY, tipe);
    }

    private void OnMouseDown()
    {
        if( !won )
        {
            roots.Expand(tipe);
        }
    }
}
