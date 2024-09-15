using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField] string nombre, apellido1, apellido2, edad;
    void Start()
    {
        string frase = ConstruirNombre(nombre, apellido1, apellido2, edad);
        Debug.Log(frase);
    }  
    string ConstruirNombre(string nombre, string apellido1, string apellido2, string edad)
    {
        string frase = nombre+" "+apellido1+" "+apellido2+" es un crack y tiene el honor de cumplir "+edad+ " este próximo 7 de octubre.";
        return frase;
    }
}
