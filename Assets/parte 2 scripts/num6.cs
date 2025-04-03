using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num6 : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > 0)
        {
            if(num1 % 2 == 0)
            {
                Debug.Log("el numero es par");
            }
            else
            {
                Debug.Log("el numero es impar");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
