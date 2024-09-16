using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int horas;
    [SerializeField] int minutos;
    [SerializeField] int segundos;
   
    void Start()
    {
        if (horas<0 || horas >=24)
        {
            Debug.Log("¡La hora no es valida!");
        }
        else if (minutos<0 || minutos >=60)
        {
            Debug.Log("¡La hora no es valida!");
        }
        else if (segundos<0 || segundos >=60)
        {
            Debug.Log("¡La hora no es valida!");
        }
        else
        {
            Debug.Log("Son las "+horas+" horas " +minutos+ " minutos y "+segundos+"segundos." );
        }
     
    }
}
