using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud;
    float area;
    void Start()
    {
        longitud = 2 * 3.14f * radio;
        area = 3.14f * (Mathf.Pow(radio, 2));
        Debug.Log("Los componentes de la circunferencia de visión del personaje son: \n" +
            "1)Radio: " + radio + ". 2)Área: " +area + ". 3)Longitud: "+longitud+".");
    }


}

