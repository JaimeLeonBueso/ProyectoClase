using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float kmHora;
    float metrosSegundo;
    void Start()
    {
        metrosSegundo = Convertir(kmHora);
        Debug.Log("El coche va a una velocidad de " + kmHora + " KM/HORA o lo que es lo mismo, va a " + metrosSegundo + " METROS/SEGUNDO.");
    }
    float Convertir(float kmHora)
    {
        float calculo = kmHora * 1000 / 3600;
        return calculo;
    }
}
