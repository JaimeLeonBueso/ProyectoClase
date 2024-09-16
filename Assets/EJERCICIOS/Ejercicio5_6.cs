using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivelPokemon;
    void Start()
    {
        if (nivelPokemon % 10 == 0)
        {
            Debug.Log("Tu pokemon ha aprendido una nueva habilidad.");
        }
        else
        {
            Debug.Log("Tu pokemon aun tiene camino por recorrer.");

        }
    }
}
