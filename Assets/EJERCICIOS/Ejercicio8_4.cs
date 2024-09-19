using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_4 : MonoBehaviour
{
    int suma = 0;
    void Start()
    {
        int[] cualquiera = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < cualquiera.Length; i++)
        {
            suma = suma + cualquiera[i];
        }
        int media = suma / 5;
        Debug.Log("La media de los 5 números es: " + media + ".");
    }


}
