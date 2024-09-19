using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_3 : MonoBehaviour
{
    void Start()
    {
        int[] cualquiera = new int [500];
        for (int i = 0; i < cualquiera.Length; i++)
        {
            cualquiera[i] = Random.Range(-50, 721);
            Debug.Log(cualquiera[i]);
        }
    }


}
