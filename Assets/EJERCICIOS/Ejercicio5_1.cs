using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vidaPlayer1;
    [SerializeField] int vidaPlayer2;
    void Start()
    {
        if (vidaPlayer1 == vidaPlayer2)
            {
            Debug.Log("There is a new challenger. La batalla va a estar reñida");    
        }
    }

   
}
