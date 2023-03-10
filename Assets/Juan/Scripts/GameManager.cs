using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public struct Move //***
    {
        public Move(int x, int y, GameObject item, GameObject font = null)
        {
            X = x;
            Y = y;
            gObj = item;
            water = font;
        }

        public int X { get; }
        public int Y { get; }
        public GameObject gObj { get; }
        public GameObject water { get; }


        public override string ToString() => $"({X}, {Y})";
    }

    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public Stack<List<Move>> moveStack;

        private void Awake()
        {
            moveStack = new Stack<List<Move>>();
            instance = this;
        }


    }
}


