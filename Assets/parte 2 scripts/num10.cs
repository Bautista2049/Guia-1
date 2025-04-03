using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num10 : MonoBehaviour
{
    bool estaAbierto;
    public int horaActual;

    // Start is called before the first frame update
    void Start()
    {
        if (horaActual > 24 || horaActual < 0)
        {
         Debug.Log("Ha ingresado una hora incorrecta");
         return;
        }
        else if(horaActual >= 10 && horaActual < 18)
        {
            estaAbierto = true;
        }
        else
        {
            estaAbierto = false; 
        }
        Debug.Log("El estabelcimiento esta ")
    }

    // Update is called once per frame

    void Update()
    {
        
    }
}
