using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comidaAnimalitos : MonoBehaviour
{
    public string animal;
    public int alimento;
    public int duraciónEstadía;

    // Start is called before the first frame update
    void Start()
    {
        if (animal == "G")
        {
            alimento = 300;
        }
        else if (animal == "PP")
        {
            alimento = 400;
        }
        else if (animal == "PG")
        {
            alimento = 700;
        }
        else
        {
            Debug.Log("El codigo de animal no existe, ingrese G, PP o PG");
            return;

        }
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
} 
