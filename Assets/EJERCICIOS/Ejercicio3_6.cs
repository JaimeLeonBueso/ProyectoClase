using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float kmHora;
    float metrosSegundo;
    void Start()
    {
        metrosSegundo = (kmHora * 1000) / 3600;
        Debug.Log("El coche va a una velocidad de " + kmHora + " KM/HORA o lo que es lo mismo, va a " + metrosSegundo + " METROS/SEGUNDO.");
    }
}