using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
 
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer juego de Jimbo.");
        Debug.Log("Estoy aprendiendo C#.");
    }


    void Update()
    {
        Debug.Log("Ha pasado un frame"); //Al ejecutarse cada frame y no producirse ningún evento que lo pare este texto se escribirá ad infinitum. 
    }
}
