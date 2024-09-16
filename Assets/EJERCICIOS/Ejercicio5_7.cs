using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidadPlayer1;
    [SerializeField] int velocidadPlayer2;
    [SerializeField] int velocidadPlayer3;
    string jugadorMasVeloz;
    void Start()
    {
        if (velocidadPlayer1 >= velocidadPlayer2 && velocidadPlayer1 >= velocidadPlayer3)
        {
           jugadorMasVeloz = "Player1";
        }
        else if (velocidadPlayer2 >= velocidadPlayer1 && velocidadPlayer2 >= velocidadPlayer3)
        {
            jugadorMasVeloz = "Player2";
        }
        else
        {
            jugadorMasVeloz = "Player3";
        }
        Debug.Log("El jugador más veloz es el "+jugadorMasVeloz+".");
    }
}