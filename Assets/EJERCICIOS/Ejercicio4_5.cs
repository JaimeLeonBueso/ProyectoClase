using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] float ladoACuadrado, ladoBCuadrado, baseTriangulo, alturaTriangulo, radioCircunferencia;
    float cantidad;
    [SerializeField] string divisa;
    string cambio;
    void Start()
    {
        float areaCuadrado = CalculoAreaCuadrado(ladoACuadrado, ladoBCuadrado);
        //Debug.Log("El área del cuadrado es:" + areaCuadrado);
        float areaTriangulo = CalculoArea(baseTriangulo, alturaTriangulo);
        //Debug.Log("El área del triángulo es:" + areaTriangulo);
        float areaCirculo = CalculoArea(radioCircunferencia);
        //Debug.Log("El área del circulo es:" + areaCirculo);
        float cantidad1 = areaCuadrado;
        float cantidad2 = areaTriangulo;
        float cantidad3 = areaCirculo;
        {
            switch (divisa)
            {
                case "Dolar":
                case "dolar":
                case "Dólar":
                case "dólar":
                case "Dolares":
                case "dolares":
                case "Dólares":
                case "dólares":
                case "$":
                    cambio = "€";

                    break;
                case "Euro":
                case "euro":
                case "Euros":
                case "euros":
                case "€":
                    cambio = "$";

                    break;
                default:
                    Debug.Log("No es una divisa válida");
                    break;
            }
            float resultado1 = Convertir(cantidad1, cambio);
            Debug.Log("El cambio a realizar por el cuadrado queda en " + resultado1 + " " + cambio + "."); 
            float resultado2 = Convertir(cantidad2, cambio);
            Debug.Log("El cambio a realizar por el triangulo queda en " + resultado2 + " " + cambio + ".");
            float resultado3 = Convertir(cantidad3, cambio);
            Debug.Log("El cambio a realizar por la circunferencia queda en " + resultado3 + " " + cambio + ".");

        }
    }
    float CalculoAreaCuadrado(float ladoA, float LadoB)
    {
        float calculo = ladoA * LadoB;
        return calculo;
    }
    float CalculoArea(float baseT, float alturaT)
    {
        float calculo = baseT * baseT / 2;
        return calculo;
    }
    float CalculoArea(float radio)
    {
        float calculo = (Mathf.Pow(radio, 2)) * 3.1416f;
        return calculo;
    }
  
    float Convertir(float cantidad, string moneda)
    {
        float calculo;
        if (moneda == "€")
        {
            calculo = cantidad * 0.9f;
        }
        else
        {
            calculo = cantidad * 1.1111111f;
        }
        return calculo;
    }

}

