using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPainter : MonoBehaviour
{
    public string content;

    private Roots root;

    private void Awake()
    {
        root = GetComponent<Roots>();
    }


    private void Start()
    {
        string[] parsed = content.Split(' ');

        int curCol = 0;
        int curRow = 0;
        for (int i = 0; i < parsed.Length; i++)
        {
            if (parsed[i] == "1")
            {
                root.roots[curCol, curRow] = Casilla.rock;
                root.placeTile(curCol, curRow, Casilla.rock);
                curCol++;
            }

            if (parsed[i] == "0")
            {
                curCol++;
            }

                if (parsed[i] == "2")
            {
                curRow++;
                curCol = 0;
            }
        }
    }





}
