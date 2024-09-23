using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private string nombre;
    [SerializeField] private float vida;
    [SerializeField] private float experiencia;
    [SerializeField] private float nivel;
    [SerializeField] float cantidadcura;
    [SerializeField] float danho;
    [SerializeField] KeyCode teclaPersonalizadaCura;
    [SerializeField] KeyCode teclaPersonalizadaDanho;
    [SerializeField] KeyCode teclaPersonalizadaReload;
    [SerializeField] SistemaDeVida miSistemaDeVida;
    [SerializeField] Arma miArma;
    [SerializeField] bool miTurno;
    [SerializeField] GameManager gameManager;
    [SerializeField] Personaje enemigo;



    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public float Nivel { get => nivel; set => nivel = value; }
    public float Cantidadcura { get => cantidadcura; set => cantidadcura = value; }
    public float Danho { get => danho; set => danho = value; }
    public SistemaDeVida MiSistemaDeVida { get => miSistemaDeVida; set => miSistemaDeVida = value; }
    public Arma MiArma { get => miArma; set => miArma = value; }
    public bool MiTurno { get => miTurno; set => miTurno = value; }
    public GameManager GameManager { get => gameManager; set => gameManager = value; }
    public Personaje Enemigo { get => enemigo; set => enemigo = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    private void Start()
    {

    }
    public float CalcularNivel()
    {
        nivel = experiencia / 1000;
        return nivel;
    }

    private void Update()
    {
        if (miTurno == true)
        {
            if (Input.GetKeyDown(teclaPersonalizadaCura))
            {
                miSistemaDeVida.RecibirCura(cantidadcura);
                Debug.Log("Te has curado " + cantidadcura + " puntos de vida te quedan " + miSistemaDeVida.VidaActual + " en total.");
                gameManager.FinDeTurno(nombre);
            }
            if (Input.GetKeyDown(teclaPersonalizadaDanho))
            {

                int exito = miArma.UtilizarArma();
                if (exito == 0)
                {
                    enemigo.miSistemaDeVida.Recibirdanho(Random.Range(miArma.DanhoMinimo, miArma.DanhoMaximo));
                    Debug.Log("Has atacado a " + enemigo.Nombre + " y le has dejado con " +enemigo.miSistemaDeVida.VidaActual+ "puntos de vida en total.");
                    gameManager.FinDeTurno(nombre);
                }
                else
                {
                    Debug.Log("Reload!!!");
                }
            }
            if (Input.GetKeyDown(teclaPersonalizadaReload))
            {
             
                int exito = miArma.RecargarArma();
                if (exito == 0)
                {
                    Debug.Log("Deprisa lentorro");
                    gameManager.FinDeTurno(nombre);
                }
                else
                {
                    Debug.Log("Arma ya esta recargada");
                }
            }
        }
    }
}

