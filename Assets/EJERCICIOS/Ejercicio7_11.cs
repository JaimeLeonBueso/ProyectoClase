using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int tablaDel;

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            { Debug.Log(tablaDel+ " x " +i+ " = " +i*tablaDel +"."); }
        }
    }
}