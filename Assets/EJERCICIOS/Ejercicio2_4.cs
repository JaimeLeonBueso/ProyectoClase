using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 10;

    void Start()
    {
        vidas = vidas + 77;
        Debug.Log("Tengo " + vidas + " vidas después de sumar 77 más.");
        vidas = vidas -3;
        Debug.Log("Tengo " + vidas + " vidas después de restar 3.");
        vidas = vidas*4;
        Debug.Log("Tengo " + vidas + " vidas después multiplicarlas por 4.");


    
    }

}
