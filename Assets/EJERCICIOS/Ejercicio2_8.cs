using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 120;
    float efectoveneno;
    float turno;
    void Start()
    {

        efectoveneno = (120 / 100) * (3 * 1);
        vida = vida - efectoveneno;
        Debug.Log("Has sido atacado, te quedan " +vida+ " puntos de vida");

        efectoveneno = (120 / 100) * (3 * 2);
        vida = vida - efectoveneno;
        Debug.Log("Has sido atacado, te quedan " + vida + " puntos de vida");

        efectoveneno = (120 / 100) * (3 * 3);
        vida = vida - efectoveneno;
        Debug.Log("Has sido atacado, te quedan " + vida + " puntos de vida");

        efectoveneno = (120 / 100) * (3 * 4);
        vida = vida - efectoveneno;
        Debug.Log("Has sido atacado, te quedan " + vida + " puntos de vida");

        efectoveneno = (120 / 100) * (3 * 5);
        vida = vida - efectoveneno;
        Debug.Log("Has sido atacado, te quedan " + vida + " puntos de vida");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
