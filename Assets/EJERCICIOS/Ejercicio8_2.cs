using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_2 : MonoBehaviour
{
    void Start()
    {
        int[] cualquiera = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < cualquiera.Length; i++)
        {
            Debug.Log("La caja con �ndice "+i+ " contiene el n�mero "+cualquiera[i]+ ".");
        }
    }


}
