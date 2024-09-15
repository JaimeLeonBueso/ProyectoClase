using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baseTriangulo,alturaTriangulo;
    float areaTriangulo;
    void Start()
    {
       areaTriangulo = (baseTriangulo*alturaTriangulo)/2;
        Debug.Log("Los componentes del triángulo de visión del personaje son: \n" +
            "1)Base: " + baseTriangulo + ". 2)Altura: " +alturaTriangulo+ ". 3)Área: " + areaTriangulo + ".");
    }


}
