using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class MapPainter : MonoBehaviour
    {

        public List<GameObject> items;
        public static MapPainter instance;
        public string content;
        private Roots root;

        private void Awake()
        {
            instance = this;
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

            if (Input.GetKeyDown(KeyCode.Z)) // "CNTROL Z"
            {
                ClearLastMoves();
            }

        }

        public void ClearMap()
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

            for (int i = 0; i < root.Waters.Count; i++)
            {
                root.Waters[i].deActivate();
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
                    root.placeTile(curCol, curRow, Casilla.rock);
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
                    root.roots[curCol, curRow] = Casilla.greenRoot;
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
                    root.roots[curCol, curRow] = Casilla.blueRoot;
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

        public void ClearLastMoves() //***
        {
            if (GameManager.instance.moveStack.Count > 0)
            {
                List<Move> movsl = GameManager.instance.moveStack.Pop();
                Move m;
                for (int i = 0; i < movsl.Count; i++)
                {
                    m = movsl[i];
                    root.roots[m.X, m.Y] = Casilla.empty;

                    GameObject del = items.Find(x => x.transform.position == m.gObj.transform.position);
                    items.Remove(del);

                    Destroy(m.gObj);

                    if (m.water != null)
                        m.water.GetComponent<ActivateWater>().activated = false;

                }
            }

        }

    }

}
