using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numeroParaWhile;
    [SerializeField] int numeroParaFor;
    int numeroControl;
    void Start()
    {
        numeroControl = 1;
        if (numeroParaWhile < 0)
        {
            Debug.Log("No es un número valido para este While, tienes que asignar un valor positivo");
        }
        else
        {
            while (numeroControl <= numeroParaWhile)
            {
                Debug.Log(numeroControl); numeroControl++;
            }
        }
        numeroControl = 1;
        if (numeroParaFor < 0)
        {
            Debug.Log("No es un número valido para este For, tienes que asignar un valor positivo");
        }
        else
        {
            for (int i = numeroControl; i <= numeroParaFor ; i++)
            {
                Debug.Log(i);
            }
        }
        }
       
    }



