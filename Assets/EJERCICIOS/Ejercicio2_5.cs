using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1, vidasPlayer1Inicio=5,
        vidasPlayer2, vidasPlayer2Inicio=10,
        vidasPlayer3, vidasPlayer3Inicio=15,
        vidasPlayer4, vidasPlayer4Inicio=20;
    


    void Start()
    {
        vidasPlayer2 = vidasPlayer3Inicio;
        Debug.Log("El player 2 tiene " + vidasPlayer2 + " vidas después de igualarlas a las iniciales del player 3.");
        vidasPlayer3 = vidasPlayer1Inicio;
        Debug.Log("El player 3 tiene " + vidasPlayer3 + " vidas después de igualarlas a las iniciales del player 1.");
        vidasPlayer1 = vidasPlayer4Inicio;
        Debug.Log("El player 1 tiene " + vidasPlayer1 + " vidas después de igualarlas a las iniciales del player 4.");
        vidasPlayer4 = vidasPlayer2Inicio;
        Debug.Log("El player 4 tiene " + vidasPlayer4 + " vidas después de igualarlas a las iniciales del player 2.");
    
    }

   
}
