using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] float cantidad;
    [SerializeField] string divisa;
  string cambio;
    void Start()
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
        float resultado = Convertir(cantidad, cambio);
        Debug.Log("El cambio a realizar queda en " +resultado+ " "+cambio+ ".");

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

