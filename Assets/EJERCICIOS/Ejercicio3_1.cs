using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_1 : MonoBehaviour
{
    [SerializeField] int numerosEntero1;
    [SerializeField] int numerosEntero2;
    void Start()
    {
        Debug.Log("Los n�meros enteros elegidos son \n" +
            "1) " + numerosEntero1 + " y " + numerosEntero2 + ".");
    }

  
}
