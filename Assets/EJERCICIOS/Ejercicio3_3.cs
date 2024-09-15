using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numeroEntero1;
    int dobleNumeroEntero1;
    int tripleNumeroEntero1;
    void Start()
    {
        dobleNumeroEntero1 = numeroEntero1 * 2;
        tripleNumeroEntero1 = numeroEntero1 * 3;
        Debug.Log("¿Te gusta ese número eh? Pues que sepas que su doble es " +dobleNumeroEntero1+ " y su triple es " +tripleNumeroEntero1+ ".");
    }


}
