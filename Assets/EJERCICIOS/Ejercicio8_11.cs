using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_11 : MonoBehaviour
{
   

    void Start()
    {
        float[] posicionesAleatorias = new float[Random.Range(5, 11)];
        for (int i = 0; i < posicionesAleatorias.Length; i++)
        {
            posicionesAleatorias[i] = Random.Range(-5f, 5f);
            Debug.Log(posicionesAleatorias[i]);
        }
    }
    
}
