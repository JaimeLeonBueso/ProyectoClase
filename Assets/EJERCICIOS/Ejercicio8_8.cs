using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_8 : MonoBehaviour
{
    int[] enterosAleatorios = new int[10];
    float sumaNegativos, contadorNegativos;
    float sumaPositivos, contadorPositivos;
    int contadorCeros;
    string visualizacionEnterosAleatorios;
    void Start()
    {
        for (int i = 0; i < enterosAleatorios.Length; i++)
        {
            enterosAleatorios[i] = Random.Range(-9, 10);
            if (enterosAleatorios[i] < 0)
            {
                sumaNegativos = sumaNegativos + enterosAleatorios[i];
                contadorNegativos++;

            }
            else if (enterosAleatorios[i] > 0)
            {
                sumaPositivos = sumaPositivos + enterosAleatorios[i];
                contadorPositivos++;
            }
            else
            {
                contadorCeros++;
            } 
        }
        float mediaNegativos = 0.00f;
        float mediaPositivos = 0.00f; 
        mediaNegativos = sumaNegativos / contadorNegativos;
        mediaPositivos = sumaPositivos / contadorPositivos;

        
        Debug.Log("La media de los numeros negativos es " +sumaNegativos+ "/" +contadorNegativos+ " = "+mediaNegativos+".");
        Debug.Log("La media de los numeros positivos es " +sumaPositivos+ "/" +contadorPositivos+ " = "+mediaPositivos+".");
        Debug.Log("Además surgieron " + contadorCeros + " ceros en la aleatoriedad");

    }


}

