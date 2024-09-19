using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_7 : MonoBehaviour
{
    int[] enterosAleatorios = new int[10];
    int sumaPares;
    int sumaImpares;
    string visualizacionEnterosAleatorios;
    void Start()
    {
        for (int i = 0; i < enterosAleatorios.Length; i++)
        {
            enterosAleatorios[i] = Random.Range(-15, 16);
            if(enterosAleatorios [i]%2 == 0)
            {
                sumaPares++;
            }
            else
            {
                sumaImpares++;
            }
        }


        for (int i = 0; i < enterosAleatorios.Length; i++)
        {
            visualizacionEnterosAleatorios = visualizacionEnterosAleatorios + enterosAleatorios[i]+ ", "; 
            
         
        }
        Debug.Log(visualizacionEnterosAleatorios);
        Debug.Log("La diosa del azar ha decidido que salgan " + sumaImpares + " números impares y "+sumaPares+ " números pares.");

      
    }


}
