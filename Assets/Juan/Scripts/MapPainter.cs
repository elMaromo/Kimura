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
        PaintString();
    }

    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ClearMap();
            PaintString();
        }

    }

    void ClearMap()
    {
        for (int i = 0; i < root.mapItems.Count; i++)
        {
            Destroy(root.mapItems[i]);
        }
        root.mapItems.Clear();

        for (int i = 0; i < root.numX; i++)
        {
            for (int j = 0; j < root.numY; j++)
            {
                root.roots[i, j] = Casilla.empty;
            }
        }
    }



    public void PaintString()
    {
        string[] parsed = content.Split(' ');

        int curCol = 0;
        int curRow = 0;
        for (int i = 0; i < parsed.Length; i++)
        {

            if (parsed[i] == "0")
            {
                curCol++;
            }

            if (parsed[i] == "2")
            {
                curRow++;
                curCol = 0;
            }

            if (parsed[i] == "1")
            {
                root.roots[curCol, curRow] = Casilla.rock;
                root.placeTile(curCol, curRow, Casilla.rock, false);
                curCol++;
            }

            if (parsed[i] == "3")
            {
                root.roots[curCol, curRow] = Casilla.redRoot;
                root.placeTile(curCol, curRow, Casilla.redTree);
                curCol++;
            }

            if (parsed[i] == "4")
            {
                root.roots[curCol, curRow] = Casilla.redWater;
                root.placeTile(curCol, curRow, Casilla.redWater);
                curCol++;
            }

            if (parsed[i] == "5")
            {
                root.roots[curCol, curRow] = Casilla.greenTree;
                root.placeTile(curCol, curRow, Casilla.greenTree);
                curCol++;
            }

            if (parsed[i] == "6")
            {
                root.roots[curCol, curRow] = Casilla.greenWater;
                root.placeTile(curCol, curRow, Casilla.greenWater);
                curCol++;
            }

            if (parsed[i] == "7")
            {
                root.roots[curCol, curRow] = Casilla.blueTree;
                root.placeTile(curCol, curRow, Casilla.blueTree);
                curCol++;
            }

            if (parsed[i] == "8")
            {
                root.roots[curCol, curRow] = Casilla.blueWater;
                root.placeTile(curCol, curRow, Casilla.blueWater);
                curCol++;
            }
        }
    }

}
