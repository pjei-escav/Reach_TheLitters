﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    static public int llaves = 0;

    public bool[] nivelesM1;


    public Animator panelSelector;
    public Animator panelTickets;
    public Animator cartelMundos;
    int mundo = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DesbloquearNivel(int nivel)
    {
        nivelesM1[nivel] = true;
    }

    public void CargarSeleccionMundo()
    {
        SceneManager.LoadScene("Seleccion_Mundo");
    }

    public void CargarSelecNivelesM1()
    {
        SceneManager.LoadScene("SelecNivelM1");
    }

    public void CargarM1N1()
    {
        SceneManager.LoadScene("M1N1");
    }

    public void CargarM1N2()
    {
        SceneManager.LoadScene("M1N2");
    }

    public void CargarM1N3()
    {
        SceneManager.LoadScene("M1N3");
    }

    public void CargarM1N4()
    {
        SceneManager.LoadScene("M1N4");
    }

    public void CargarPantallaPrincipal()
    {
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void CargarPantallaOpciones()
    {
        SceneManager.LoadScene("PantallaOpciones");
    }

    public void CargarPantallaJuego()
    {
        SceneManager.LoadScene("PantallaInicio");
    }

    public void SiguienteMundo()
    {
        mundo++;
        panelSelector.SetInteger("Mundo", mundo);
        panelTickets.SetInteger("Mundo", mundo);
        cartelMundos.SetInteger("Mundo", mundo);
    }

    public void AnteriorMundo()
    {
        mundo--;
        panelSelector.SetInteger("Mundo", mundo);
        panelTickets.SetInteger("Mundo", mundo);
        cartelMundos.SetInteger("Mundo", mundo);
    }
}
