using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numeroParaWhileInicio=0; int numeroParaWhileFinal;
    [SerializeField] int numeroParaForInicio=0; int numeroParaForFinal;
    void Start()
    {
       numeroParaWhileFinal= -numeroParaWhileInicio;
        numeroParaForFinal= -numeroParaForInicio;
        if (numeroParaWhileInicio <= 0)
        {
            Debug.Log("No es un número valido para este While, tienes que asignar un valor positivo");
        }
        else
        {
            while (numeroParaWhileInicio>= numeroParaWhileFinal)
            {
                Debug.Log(numeroParaWhileInicio); numeroParaWhileInicio--;
            }
        }
       
        if (numeroParaForInicio <= 0)
        {
            Debug.Log("No es un número valido para este For, tienes que asignar un valor positivo");
        }
        else
        {
            for (int i = numeroParaForInicio; i >= numeroParaForFinal; i--)
            {
                Debug.Log(i);
            }
        }
    }

} 