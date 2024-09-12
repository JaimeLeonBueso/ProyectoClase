using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    float oroAcumulado;
    float temporizador=4; //14.400segundos,240minutos, 4horas

    void Update()
    {
        temporizador -= Time.deltaTime;
        if (temporizador >= 0)
        {
            temporizador -= Time.deltaTime;
            oroAcumulado = oroAcumulado + (7 * 3600 *Time.deltaTime);
        }
        if (temporizador < 0)
        {
            temporizador = 0;
        }
        if (temporizador == 0)
        {
            Debug.Log(oroAcumulado);
        }

       
    }
}