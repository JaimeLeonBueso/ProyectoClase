using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {

        if (numero1 < numero2)
        {
            for (int i = numero1; i <= numero2; i++)
            {
                if (i % 2 == 0)
                { Debug.Log(i); }
            }
        }
        else if (numero2 < numero1)
        {
            for (int i = numero2; i <= numero1; i++)
            {
                if (i % 2 == 0)
                { Debug.Log(i); }
            }
        }
        else
        {
            Debug.Log("Los numeros son iguales y no existe sucesión entre ellos.");
        }
    }

}
