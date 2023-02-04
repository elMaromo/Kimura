using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace juan
{
    public class ActivateWater : MonoBehaviour
    {
        public Casilla tipe;
        public string stringTipe;

        public bool activated;

        private void Start()
        {
            activated = false;
        }

        private void Update()
        {
            Collider2D[] cols = Physics2D.OverlapCircleAll(transform.position, 0.1f);

            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].gameObject.tag == stringTipe)
                {
                    activated = true;
                }
            }

        }

        public void deActivate()
        {
            activated = false;
        }
    }
}

