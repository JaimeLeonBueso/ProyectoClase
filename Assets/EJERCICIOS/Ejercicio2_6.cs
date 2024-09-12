using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int HighScore1 = 1000, HighScore2 = 2000, HighScore3 = 2300;
    

    void Start()
    {
       int mediaHighScores = (HighScore1+HighScore2+HighScore3)/3;
        Debug.Log("Las 3 mejores puntuaciones del jugador son: 1)"+HighScore3+ " 2)" +HighScore2+ " 3)" +HighScore1+ ".");
        Debug.Log("La media de sus mejores puntuaciones es: " + mediaHighScores + ".");

    }

}
