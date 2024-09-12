using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas =3;
    float exp =100;
    char carac = 'J';
    float resultadoSuma, resultadoResta;
    void Start()
    {
        Debug.Log("Tengo " + vidas + " vidas y he acumulado " + exp + " puntos de experiencia.");
        resultadoSuma = vidas+exp;
        resultadoResta = exp-vidas;
        Debug.Log("Tras realizar unas operaciones tengo que:\n" +
            "la suma de Vidas y Experiencia es " + resultadoSuma + " y que el resultado de restarle Vidas a la Experiencia es " + resultadoResta + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
