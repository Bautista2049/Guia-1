﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num1 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        num1 = 0;
        Debug.Log(num1);
        num1 = 2;
        Debug.Log(num1);
        num1 = 2 * 2;
        Debug.Log(num1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
