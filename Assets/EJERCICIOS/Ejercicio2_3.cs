using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 3;
    float exp = 100f;
    char carac = 'J';
    float resultadoProducto, resultadoDivision, resultadoDuplicar, resultadoTriplicar, resultadoResto;
  
    void Start()
    {
        resultadoProducto = vidas * exp;
        resultadoDivision = vidas / exp;
        resultadoResto = vidas%exp;
        resultadoDuplicar = vidas * 2;
        resultadoTriplicar = exp * 3;
       print("Tras realizar unas operaciones tengo que:\n" +
            "El producto de Vidas y Experiencia es " + resultadoProducto + ".\n" +
            "la división de Vidas entre Experiencia es " + resultadoDivision + ".\n" +
            "El resto de la division de suma entre Vidas es " + resultadoResto + ".\n" +
            "El doble de Vidas es " + resultadoDuplicar + ".\n" +
            "El triple de Experiencia es " + resultadoTriplicar + ".\n");
    }

    void Update()
    {

    }
}
