using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {

            for (int i = 1; i <= numero; i++)
            {
                if (i % 3 == 0)
                { Debug.Log(i); }
            }
       
    }

}
