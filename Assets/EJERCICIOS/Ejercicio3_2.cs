using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_2 : MonoBehaviour
{
    [SerializeField] string nombreUsuario;

    void Start()
    {
        Debug.Log("Bienvenido de nuevo, " +nombreUsuario+ ".");
    }


}

