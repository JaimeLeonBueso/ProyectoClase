using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeBis : MonoBehaviour
{

    [SerializeField] private string nombre;
    [SerializeField] private float vida;
    [SerializeField] private float ataque;
    [SerializeField] private float velocidad;
    [SerializeField] PersonajeBis objetivo;

    
    public float Vida { get => vida; set => vida = value; }
    public float Ataque { get => ataque; set => ataque = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public PersonajeBis Objetivo { get => objetivo; set => objetivo = value; }
    public string Nombre1 { get => nombre; set => nombre = value; }

    public void RellenarStats(float atq, float vel, float hp)
    { 
        ataque = atq;
        velocidad = vel;
        vida = hp;
    }
    
    public void MarcarObjetivo(PersonajeBis objetivob)
    {
        objetivo = objetivob;
    }
  
    public void Atacar()
    {
        objetivo.vida = objetivo.vida - ataque;
    }
}
