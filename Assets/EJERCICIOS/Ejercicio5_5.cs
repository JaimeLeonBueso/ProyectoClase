using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivelPersonaje;
    void Start()
    {
        int moduloNivelPersonaje = nivelPersonaje % 2;
        if(moduloNivelPersonaje == 0 )
        {
            Debug.Log(nivelPersonaje + " es un numero par.");
        }
        else
        {
            Debug.Log(nivelPersonaje + " es un numero impar.");
        }
    }
}
