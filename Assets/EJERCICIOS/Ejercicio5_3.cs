using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numeroEntero;
 
    void Start()
    {
        if (numeroEntero>=0 && numeroEntero<=9)
        {
            Debug.Log("El número está comprendido entre 0 y 9");
        }
    }


}
