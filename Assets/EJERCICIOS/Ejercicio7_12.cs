using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    int sumaAcumulada;
    void Start()
    {
        sumaAcumulada = SumarTodosLosNumeros(numero1, numero2);
        Debug.Log("La suma acumulada es: " + sumaAcumulada + ".");
    }
    int SumarTodosLosNumeros (int numero1, int numero2)
    {
        int sumaAcumuladaInterna=0;
        if (numero1 < numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
               sumaAcumuladaInterna = sumaAcumuladaInterna + i;
            }
        }
        else if (numero2 < numero1)
        {
            for (int i = numero2; i <= numero1; i++)
            {
                sumaAcumuladaInterna = sumaAcumuladaInterna + i;
            }
        }
        else
        {
            Debug.Log("Los numeros son iguales y no existe sucesión entre ellos.");
        }
        return sumaAcumuladaInterna;

    }

}
