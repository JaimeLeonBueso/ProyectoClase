using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Personaje personaje;
    
    void Start()
    {
        
    }

    void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape))
        {
            PrepararPersonajes();   
        }
    }
    void PrepararPersonajes()
    {
        personaje.Vida = 0;
    }
}
