using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {

        if (numero1 < numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
                if (i % 2 == 0 && i <0)
                { Debug.Log(i+" es un n�mero negativo y par."); }
                else if (i % 2 != 0 && i < 0)
                { Debug.Log(i + " es un n�mero negativo e impar."); }
                else if (i % 2 == 0 && i > 0)
                { Debug.Log(i + " es un n�mero positivo y par."); }
                else if (i % 2 != 0 && i > 0)
                { Debug.Log(i + " es un n�mero positivo e impar."); }
                else
                { Debug.Log("Con este has ido a pillar, el cero es par y neutro"); }
            }
        }
        else if (numero2 < numero1)
        {
            for (int i = numero2; i <= numero1; i++)
            {
                if (i % 2 == 0 && i < 0)
                { Debug.Log(i + " es un n�mero negativo y par."); }
                else if (i % 2 != 0 && i < 0)
                { Debug.Log(i + " es un n�mero negativo e impar."); }
                else if (i % 2 == 0 && i > 0)
                { Debug.Log(i + " es un n�mero positivo y par."); }
                else if (i % 2 == 0 && i < 0)
                { Debug.Log(i + " es un n�mero positivo e impar."); }
                else
                { Debug.Log("Con este has ido a pillar, el cero es par y neutro"); }
            }
        }
        else
        {
            Debug.Log("Los numeros son iguales y no existe sucesi�n entre ellos.");
        }
    }

}
