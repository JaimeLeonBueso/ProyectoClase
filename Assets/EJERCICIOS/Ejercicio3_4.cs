using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float xp;
    float lvl;
    void Start()
    {
        lvl = 32 + (9 * xp / 5);
        Debug.Log("El nivel de tu personajes es "+lvl+ ".");
    }


}

