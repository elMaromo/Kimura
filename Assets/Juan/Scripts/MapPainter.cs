using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPainter : MonoBehaviour
{
    public Sprite spRock;
    public string content;

    public int level;

    private Roots root;

    private void Awake()
    {
        root = GetComponent<Roots>();
    }


    private void Start()
    {
        string[] parsed = content.Split(' ');

        //int cont 
        for (int i = 0; i < parsed.Length; i++)
        {
            //if(parsed[i] == 1)
            {
                //root.roots[]
            }
        }
    }


    

    
}
