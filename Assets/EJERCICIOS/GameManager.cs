using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje personaje1;
    [SerializeField] Personaje personaje2;
   [SerializeField] bool yaEjecutado;
    

    void Update()
    {
      
    if(Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();   
        }
    }
    void PrepararPersonajes()
    {
        if (!yaEjecutado)
        {
           
            personaje1.Experiencia = 10000;
            personaje1.Vida = 1000;
            personaje1.Nombre = "Mario";
            personaje1.CalcularNivel();
            Debug.Log(personaje1.Nombre + " tiene nivel " + personaje1.Nivel + ".");
            personaje2.Experiencia = 25000;
            personaje2.Vida = 500;
            personaje2.Nombre = "Luigi";
            personaje2.CalcularNivel();
            Debug.Log(personaje2.Nombre + " tiene nivel " + personaje2.Nivel + ".");
            yaEjecutado = true;
        }
    }

    public void FinDeTurno(string personajeActivo)
    { 
        if (personajeActivo == personaje1.Nombre)
        {
            personaje1.MiTurno = false;
            personaje2.MiTurno = true;
            Debug.Log("El turno de " + personaje1.Nombre + " ha terminado");
        }
        if (personajeActivo == personaje2.Nombre)
        {
            personaje2.MiTurno = false;
            personaje1.MiTurno = true;
            Debug.Log("El turno de " + personaje2.Nombre + " ha terminado");
        }
    }
}
