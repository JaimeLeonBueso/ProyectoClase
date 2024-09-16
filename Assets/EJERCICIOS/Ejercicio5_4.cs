using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        if (numero2 !=0)
        {
            int resultado = numero1/numero2;
            Debug.Log("La división de "+numero1+" entre "+numero2+ " es igual a "+resultado+".");
        }
    }


}
