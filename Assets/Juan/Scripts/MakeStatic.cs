using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStatic : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
