using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int edadUser;
    float sueldoUser;
    string domicilio;
    bool estaAprobado;
    
    // Start is called before the first frame update
    void Start()
    {
        edadUser = 66;
        sueldoUser = 1500.00f;
        domicilio = "Libertador 1918";
        estaAprobado = true;

        Debug.Log(edadUser);
        Debug.Log(sueldoUser);
        Debug.Log(domicilio);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
