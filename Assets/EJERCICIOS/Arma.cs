using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMinimo;
    [SerializeField] float danhoMaximo;
    [SerializeField] float capacidadTotal;
    [SerializeField] bool automatica;
    [SerializeField] float municionActual;

    public float DanhoMinimo { get => danhoMinimo; set => danhoMinimo = value; }
    public float DanhoMaximo { get => danhoMaximo; set => danhoMaximo = value; }
    public float CapacidadTotal { get => capacidadTotal; set => capacidadTotal = value; }
    public bool Automatica { get => automatica; set => automatica = value; }
    public float MunicionActual { get => municionActual; set => municionActual = value; }



    private void Start()
    {
        municionActual = capacidadTotal;
    }
    public int UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
            Debug.Log("Has usado el arma, te quedan " + municionActual + " balas.");
            return 0;
        }
        else
        {
            return -1;
        }
    }
    public int RecargarArma()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            Debug.Log("Has recargado el arma, vuelves a tener " + capacidadTotal + " balas.");
            return 0;
        }
        else
        {
            return -1;
        }
    }
}


