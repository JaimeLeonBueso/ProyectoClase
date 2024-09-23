using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaInicial;
    [SerializeField] float vidaActual;

    public float VidaInicial { get => vidaInicial; set => vidaInicial = value; }
    public float VidaActual { get => vidaActual; set => vidaActual = value; }

    private void Start()
    {
        vidaActual = vidaInicial;
    }

    public float RecibirCura(float cantidad)
    {
        if (cantidad > 0 && vidaActual<vidaInicial)
        {
            vidaActual += cantidad;
            if (vidaActual > vidaInicial)
            {
                return vidaInicial; 
            }
            else
            { 
                return vidaActual; 
            }
        }
        else
        {
            return -1;
        }
    }

    public float Recibirdanho(float danho)
    {
        if (danho > 0)
        {
            vidaActual -= danho;
            if (vidaActual <= 0)
            {
                return 0;
            }
            else
            {
                return vidaActual;
            }
        }
        else
        {
            return -1;
        }
    }
}

