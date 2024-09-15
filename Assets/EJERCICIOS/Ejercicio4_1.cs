using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float ladoACuadrado, ladoBCuadrado, baseTriangulo, alturaTriangulo, radioCircunferencia;
    void Start()
    {
        float areaCuadrado = CalculoAreaCuadrado(ladoACuadrado,ladoBCuadrado);
        Debug.Log("El área del cuadrado es:"+ areaCuadrado);    
        float areaTriangulo = CalculoArea(baseTriangulo, alturaTriangulo);
        Debug.Log("El área del triángulo es:" + areaTriangulo);   
        float areaCirculo = CalculoArea(radioCircunferencia);
        Debug.Log("El área del circulo es:" + areaCirculo);
    }
    float CalculoAreaCuadrado(float ladoA,  float LadoB)
    {
       float calculo= ladoA*LadoB;
        return calculo;
    }
    float CalculoArea( float baseT,  float alturaT)
    {
        float calculo= baseT*baseT/2;
        return calculo;
    }
    float CalculoArea( float radio)
    {
        float calculo = (Mathf.Pow(radio, 2)) * 3.1416f;
        return calculo;
    }
}
