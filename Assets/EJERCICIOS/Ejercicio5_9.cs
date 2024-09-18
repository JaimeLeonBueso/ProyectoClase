using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] char tipo;
    int danho;
    int vida;
  
    void Start()
    {
        switch (tipo)
        {
            case '1':
                danho = 350;vida = 650;
                break;
            case '2':
                danho = 300;vida = 550;
                break;
            case '3':
                danho = 300;vida = 500;
                break;
            case '4':
                danho = 310;vida = 460;
                break;
            case '5':
                danho = 280;vida = 490;
                break;
            case '6':
                danho = 360;vida = 520;
                break;
            default:
                Debug.Log("No es un tipo válido");
                tipo = '7';
                break;
        }
        if (tipo != '7')
        { Debug.Log("El enemigo de tipo " + tipo + " hace un daño de " + danho + " y tiene una vida de " + vida + "."); }

    }

}

