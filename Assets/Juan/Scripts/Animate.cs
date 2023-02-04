using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    public Sprite sp1;
    public Sprite sp2;

    public float maxTime;
    public float minTime;
    public bool rand;
    public float constTime;
    float timer;

    private SpriteRenderer spRend;
    private void Awake()
    {
        if (rand == true)
            timer = Random.Range(minTime, maxTime);
        else
            timer = constTime;

        spRend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            if (spRend.sprite.name == sp1.name)
                spRend.sprite = sp2;
            else
                spRend.sprite = sp1;

            if (rand == true)
                timer = Random.Range(minTime, maxTime);
            else
                timer = constTime;
        }
        else
            timer -= Time.deltaTime;

        
    }
}
