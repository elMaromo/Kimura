using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class Undo : MonoBehaviour
    {
        SpriteRenderer spRend;
        private float timer;

        private void Awake()
        {
            spRend = GetComponent<SpriteRenderer>();
            spRend.color = new Color(1f, 1f, 1f, 0f);
        }

        private void Start()
        {
            timer = 0;
        }

        private void OnMouseDown()
        {
            spRend.color = new Color(1f, 1f, 1f, 1f);
            timer = 0.5f;

            MapPainter.instance.ClearLastMoves();
        }
        private void Update()
        {

            if (timer <= 0)
            {
                spRend.color = new Color(1f, 1f, 1f, 0f);
            }
                

            timer -= Time.deltaTime;
        }
    }
}
