using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio8_5 : MonoBehaviour
{
    int[] nivelesDificultad = { 1, 5, 7, 10};
    string[] nombreNiveles = { "La Ciudad", "El Bosque", "La Ciénaga", "El Castillo de Alucard"};
    void Start()
    {
       
        for (int i = 0; i < nivelesDificultad.Length; i++)
        {
            Debug.Log("El nivel número " +(i+1)+ " llamado \""+nombreNiveles[i]+ "\" tiene una dificultad de "+nivelesDificultad[i]+".");
        }
        float suma=0;
        for (int i = 0; i < nivelesDificultad.Length; i++)
        {
            suma = suma + nivelesDificultad[i];
        }
        float media = suma / 4;
        Debug.Log("La media de los 4 niveles es: " + media + ".");

        for (int i = 0; i < nivelesDificultad.Length; i++)
        {
            if (nivelesDificultad[i] > media)
            {
                Debug.Log("Ladificultad del nivel llamado \"" + nombreNiveles[i] + "\" tiene una dificultad superior a la media.");
            }
        }
    }


}
