﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMady : MonoBehaviour
{
    AudioSource sonido;
    public AudioClip normal;
    public AudioClip triste;
    bool piar = true;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (piar)
        {
            piar = false;
            Invoke("Piar", Random.Range(5,15));
        }
    }

    public void Piar()
    {
        piar = true;
        sonido.clip = normal;
        sonido.Play();
    }

    public void Triste()
    {
     
        sonido.clip = triste;
        sonido.Play();
    }
}
