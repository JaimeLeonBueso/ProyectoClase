using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrALaGuerra : MonoBehaviour
{
    [SerializeField] Batalla batalla;
    bool crearempa;
    bool generarcombatientes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && generarcombatientes == false)
        {
            batalla.GenerarCombatientes();
            generarcombatientes = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && crearempa == false)
        {

            batalla.CrearEmparejamiento();
            crearempa = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            batalla.GenerarCombate();
        }
    }
}
               

         

     

