using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    float segundosTranscurridos = 14400;
    float oroPorSegundo = 7;
    float oroAcumulado;
    float temporizador=4; //14.400segundos,240minutos, 4horas


    void Start()
    {
        oroAcumulado = segundosTranscurridos * oroPorSegundo;
        Debug.Log("El jugador ha acumulado "+oroAcumulado+ " unidades de oro en estas 4 horas");
        


    }
    //void Start()
    //{
    //    temporizador -= Time.deltaTime;
    //    if (temporizador >= 0)
    //    {
    //        temporizador -= Time.deltaTime;
    //        oroAcumulado = oroAcumulado + (7 * 3600 *Time.deltaTime);
    //    }
    //    if (temporizador < 0)
    //    {
    //        temporizador = 0;
    //    }
    //    if (temporizador == 0)
    //    {
    //        Debug.Log(oroAcumulado);
    //    }


    //}
}