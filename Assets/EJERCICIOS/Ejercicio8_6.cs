using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_6 : MonoBehaviour
{
    int[] veintePrimerosPares = new int [20];
 
    void Start()
    {

        for (int i = 0; i < 40; i = i + 2)
        {
            veintePrimerosPares[i / 2] = i;
        }

        float suma = 0;
        for (int i = 0; i < veintePrimerosPares.Length; i++)
        {
            suma = suma + veintePrimerosPares[i];
        }
        
        Debug.Log("La suma de los 20 pares es: " + suma + ".");

    }


}