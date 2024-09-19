using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_9 : MonoBehaviour
{
    string[] nombres = { "Arghz", "Bergzs", "Cergzs", "Dortzh", "Erthz", "Forz", "Grozg", "Hortuz", "Intz", "Jarl" };
    float[] danhoNombres = new float[10];
    float danhoMasAlto;
    string nombreMasAlto;
    void Start()
    {
        for (int i = 0; i < danhoNombres.Length; i++)
        {
            danhoNombres[i] = Random.Range(50, 151);
        }
        
        for (int i = 0; i < nombres.Length; i++)
        {
           Debug.Log(nombres[i]+" hace " +danhoNombres[i]+ " puntos de daño.");
        } 
        
        for (int i = 0; i < danhoNombres.Length; i++)
        {
            if (danhoMasAlto < danhoNombres[i])
            {
                danhoMasAlto = danhoNombres[i];
                nombreMasAlto = nombres[i];
            }
        }
           Debug.Log(nombreMasAlto+" es el enemigo mas fuerte y hace " +danhoMasAlto+ " puntos de daño.");
        
    }
}
     