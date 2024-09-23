using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.PackageManager;
using UnityEngine;

public class Batalla : MonoBehaviour
{
    [SerializeField] private PersonajeBis player1;
    [SerializeField] private PersonajeBis player2;
    [SerializeField] private PersonajeBis player3;
    [SerializeField] private PersonajeBis player4;
    [SerializeField] private PersonajeBis combatiente1;
    [SerializeField] private PersonajeBis combatiente2;
    [SerializeField] bool iniciativaCombatiente1;
    [SerializeField] bool iniciativaCombatiente2;
    [SerializeField] int sorteo1;
    [SerializeField] int sorteo2;
    [SerializeField] bool iniciativacheck;

    private void Update()
    {

    }
    public void GenerarCombatientes()
    {
        player1.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        Debug.Log("El azar ha decidido que " + player1 + " tenga " + player1.Ataque + " puntos de ataque, " + player1.Velocidad + " puntos de velocidad y " + player1.Vida + " puntos de vida.");
        player2.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        Debug.Log("El azar ha decidido que " + player2 + " tenga " + player2.Ataque + " puntos de ataque, " + player2.Velocidad + " puntos de velocidad y " + player2.Vida + " puntos de vida.");
        player3.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        Debug.Log("El azar ha decidido que " + player3 + " tenga " + player3.Ataque + " puntos de ataque, " + player3.Velocidad + " puntos de velocidad y " + player3.Vida + " puntos de vida.");
        player4.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        Debug.Log("El azar ha decidido que " + player4 + " tenga " + player4.Ataque + " puntos de ataque, " + player4.Velocidad + " puntos de velocidad y " + player4.Vida + " puntos de vida.");
    }

    public void CrearEmparejamiento()
    {
        sorteo1 = Random.Range(1, 5);
        sorteo2 = Random.Range(1, 5);
        if (sorteo1 == sorteo2 && sorteo1 != 4)
        {
            sorteo2 += 1;
        }
        if (sorteo1 == sorteo2 && sorteo1 == 4)
        {
            sorteo2 -= 1;
        }

        //while (sorteo1 == sorteo2)
        // {
        // sorteo2 = Random.Range(1, 5);
        // }

        if (sorteo1 == 1)
        { combatiente1 = player1; }
        else if (sorteo1 == 2)
        { combatiente1 = player2; }
        else if (sorteo1 == 3)
        { combatiente1 = player3; }
        else
        { combatiente1 = player4; }

        if (sorteo2 == 1)
        { combatiente2 = player1; }
        else if (sorteo2 == 2)
        { combatiente2 = player2; }
        else if (sorteo2 == 3)
        { combatiente2 = player3; }
        else
        { combatiente2 = player4; }
        combatiente1.MarcarObjetivo(combatiente2);
        combatiente2.MarcarObjetivo(combatiente1);
        Debug.Log("El sorteo ha enfrentado a " + combatiente1 + " contra " + combatiente2 + ".");

    }

    public void GenerarCombate()
    {
        if (iniciativacheck == false)
        {
            if (combatiente1.Velocidad > combatiente2.Velocidad)
            {
                iniciativaCombatiente1 = true;
                iniciativacheck = true;
            }
            else
            {
                iniciativaCombatiente2 = true;
                iniciativacheck = true;
            }
        }
        if (iniciativacheck == true)
        {
            while (combatiente2.Vida > 0 && combatiente1.Vida > 0)
            {
                if (iniciativaCombatiente1 == true)
                {
                    combatiente1.Atacar();
                    iniciativaCombatiente1 = false;
                    iniciativaCombatiente2 = true;
                    Debug.Log(combatiente1 + "ataca a " + combatiente2 + "y lo deja a " + combatiente2.Vida + " puntos de vida.");
                }
                else if (iniciativaCombatiente2 == true)
                {
                    combatiente2.Atacar();
                    iniciativaCombatiente2 = false;
                    iniciativaCombatiente1 = true;
                    Debug.Log(combatiente2 + "ataca a " + combatiente1 + "y lo deja a " + combatiente1.Vida + " puntos de vida.");
                }

                if (combatiente1.Vida < 0)
                {
                    Debug.Log("Ha muerto el combatiente numero 1.");
                }
                if (combatiente2.Vida < 0)
                {
                    Debug.Log("Ha muerto el combatiente numero 2.");
                }
            }
        }
    }
}