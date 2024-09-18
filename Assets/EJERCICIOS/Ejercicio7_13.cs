using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numeroAExaminar;
    void Start()
    {
        
        bool esprimo = EsPrimo(numeroAExaminar);
        if (esprimo) 
        { Debug.Log(numeroAExaminar + " es primo."); }
        else
        { Debug.Log(numeroAExaminar + " no es primo."); }
    }
    bool EsPrimo(int numeroAExaminar)
    {
        bool esPrimo;
        if (numeroAExaminar % 2 == 0 && numeroAExaminar!=2)
        { esPrimo = false; }
        else if (numeroAExaminar % 3 == 0 && numeroAExaminar != 3)
        { esPrimo = false; }
        else if (numeroAExaminar % 4 == 0 && numeroAExaminar != 4)
        { esPrimo = false; }
        else if (numeroAExaminar % 5 == 0 && numeroAExaminar != 5)
        { esPrimo = false; }
        else if (numeroAExaminar % 6 == 0 && numeroAExaminar != 6)
        { esPrimo = false; }
        else if (numeroAExaminar % 7 == 0 && numeroAExaminar != 7)
        { esPrimo = false; }
        else if (numeroAExaminar % 8 == 0 && numeroAExaminar != 8)
        { esPrimo = false; }
        else if (numeroAExaminar % 9 == 0 && numeroAExaminar != 9)
        { esPrimo = false; }
        else
        { esPrimo = true; }
        return esPrimo;
    }

        }