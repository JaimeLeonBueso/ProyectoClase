using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre;
    private float vida;
    private float experiencia;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }

    public float CalcularNivel()
    {
        float lvl = experiencia / 1000;
        return lvl;
    }
}
