using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int vidaPlayer1;
    [SerializeField] int vidaPlayer2;
    void Start()
    {
        if (vidaPlayer1 <3 && vidaPlayer2 <3)
        {
            Debug.Log("Los dos números son menores que 3");
        }
    }


}
