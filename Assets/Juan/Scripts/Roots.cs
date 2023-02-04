using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Casilla
{
    empty,
    rock,
    greenRoot,
    redRoot,
    blueRoot,
    greenWater,
    redWater,
    blueWater
}

public class Roots : MonoBehaviour
{
    public int numX, numY;

    public GameObject greenRoot, redRoot, blueRoot, rock;
    public Casilla[,] roots;

    
    private void Awake()
    {
        roots = new Casilla[numX, numY];
        for (int i = 0; i < numX; i++)
        {
            for (int j = 0; j < numY; j++)
            {
                roots[i,j] = Casilla.empty;
            }
        }
    }

    public void Expand( Casilla tipe )
    {
        Debug.Log("eo1");
        bool[,] toExpand = new bool[numX, numY];
        for ( int i = 0; i < numX; i++ )
        {
            for (int j = 0; j < numY; j++)
            {
                if(roots[i,j] == Casilla.empty && AdyacentOfColor( i,  j, tipe) )
                {
                    Debug.Log("eo2");
                    toExpand[i, j] = true;
                }
            }
        }

        for (int i = 0; i < numX; i++)
        {
            for (int j = 0; j < numY; j++)
            {
                if (toExpand[i, j] == true)
                {
                    Debug.Log("eo3");
                    roots[i, j] = tipe;
                    placeTile(i, j, tipe);
                }
            }
        }
    }

    private bool AdyacentOfColor(int x, int y, Casilla tipe)
    {
        bool adyacent = false;
        Casilla c;

        if (x - 1 >= 0)
        {
            c = roots[x - 1, y];
            if (c == tipe)
                adyacent = true;

        }
        if (y - 1 >= 0)
        {
            c = roots[x, y - 1];
            if (c == tipe)
                adyacent = true;
        }
        if (x + 1 < numX)
        {
            c = roots[x + 1, y];
            if (c == tipe)
                adyacent = true;
        }
        if (y + 1 < numY)
        {
            c = roots[x, y + 1];
            if (c == tipe)
                adyacent = true;
        }

        return adyacent;
    }

    public void placeTile( int i, int j, Casilla tipe )
    {
        if( tipe == Casilla.greenRoot )
        {
            Instantiate(greenRoot, transform.position + new Vector3(i, j, 0), transform.rotation);
        }

        if (tipe == Casilla.blueRoot)
        {
            Instantiate(blueRoot, transform.position + new Vector3(i, j, 0), transform.rotation);
        }

        if (tipe == Casilla.redRoot)
        {
            Instantiate(redRoot, transform.position + new Vector3(i, j, 0), transform.rotation);
        }

        if (tipe == Casilla.rock)
        {
            Instantiate(rock, transform.position + new Vector3(i, j, 0), transform.rotation);
        }
    }


}
