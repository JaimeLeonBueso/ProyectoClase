using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] float temperatura;
    void Start()
    {
        if (temperatura <= 10)
        { Debug.Log("Tu personaje ha entrado en un clima fr�o, abr�gate."); }
        else if (temperatura > 10 && temperatura <= 20)
        { Debug.Log("Tu personaje ha entrado en un clima nublado, ponte el chubasquero."); }
        else if (temperatura > 20 && temperatura <= 30)
        { Debug.Log("Tu personaje ha entrado en un clima caluroso, toca camiseta y pantal�n corto."); }
        else
        { Debug.Log("Tu personaje ha entrado en un clima tropical, a ponerse el ba�ador."); }
    }
}
                           


                        
