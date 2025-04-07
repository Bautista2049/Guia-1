using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionMoneda : MonoBehaviour
{
    //1. Declaracion de variables
    public float monto;
    public string moneda;
    float montoConvertido;
    float montoMinimo = 1000;
    float cotizacionMonedaElegida;
    float cotizacionEuro = 1621.3f;
    float cotizacionDolar = 1293.21f;
    float cotizacionReal = 1336.7f;
    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso y validacion de datos
        if (monto < montoMinimo) 
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (moneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        }
        else if (moneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (moneda == "R") 
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        //3. Procesamiento de datos

        montoConvertido = monto / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("La cotización de ese monto a pesos es" + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
