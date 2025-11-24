using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColision : MonoBehaviour
{
    //Audios
    public AudioSource reproductor;
    public AudioClip crowd_cheer;
    public AudioClip fabrica;
    public AudioClip gasolinera;

    //Videos
    public GameObject videoRandom;

    //Imagenes
    public Image frutas;
    public Image panaderia;
    public Image ComidaRapida;
    public Image CoffeeShop;
    public Image bar;
    public Image farmacia;
    public Image PolloFrito;
    public Image restaurante;
    public Image TiendaRegalos;
    public Image pizzeria;


    void Start()
    {
        //Imagenes
        frutas.gameObject.SetActive(false);
        panaderia.gameObject.SetActive(false);
        ComidaRapida.gameObject.SetActive(false);
        CoffeeShop.gameObject.SetActive(false);
        bar.gameObject.SetActive(false);
        farmacia.gameObject.SetActive(false);
        PolloFrito.gameObject.SetActive(false);
        restaurante.gameObject.SetActive(false);
        TiendaRegalos.gameObject.SetActive(false);
        pizzeria.gameObject.SetActive(false);
        
        //Videos
        videoRandom.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj)
    {
        //Imagenes
        if (obj.tag == "fruteria")
        {
            frutas.gameObject.SetActive(true);
        }

        if (obj.tag == "panaderia")
        {
            panaderia.gameObject.SetActive(true);
        }

        if (obj.tag == "farmacia")
        {
            farmacia.gameObject.SetActive(true);
        }

        if (obj.tag == "ComidaRapida")
        {
            ComidaRapida.gameObject.SetActive(true);
        }

        if (obj.tag == "PolloFrito")
        {
            PolloFrito.gameObject.SetActive(true);
        }

        if (obj.tag == "restaurante")
        {
            restaurante.gameObject.SetActive(true);
        }

        if (obj.tag == "TiendaRegalos")
        {
            TiendaRegalos.gameObject.SetActive(true);
        }

         if (obj.tag == "CoffeeShop")
        {
            CoffeeShop.gameObject.SetActive(true);
        }

        if (obj.tag == "bar")
        {
            bar.gameObject.SetActive(true);
        }

        if (obj.tag == "pizzeria")
        {
            pizzeria.gameObject.SetActive(true);
        }

        //Videos
        if (obj.tag == "cine")
        {
            videoRandom.SetActive(true);
        }

        //Ruidos one shot
        if (obj.tag == "estadio")
        {
            reproductor.PlayOneShot(crowd_cheer);
        }

        if (obj.tag == "gasolinera")
        {
            reproductor.PlayOneShot(gasolinera);
        }

        if (obj.tag == "fabrica")
        {
            reproductor.PlayOneShot(fabrica);
        }
    }
    
    private void OnTriggerExit(Collider obj)
    {
        // Audio
        reproductor.Stop();

        //Imagenes
        if (obj.tag == "fruteria")
        {
            frutas.gameObject.SetActive(false);
        }

        if (obj.tag == "panaderia")
        {
            panaderia.gameObject.SetActive(false);
        }

         if (obj.tag == "CoffeeShop")
        {
            CoffeeShop.gameObject.SetActive(false);
        }

        if (obj.tag == "farmacia")
        {
            farmacia.gameObject.SetActive(false);
        }

        if (obj.tag == "ComidaRapida")
        {
            ComidaRapida.gameObject.SetActive(false);
        }

        if (obj.tag == "PolloFrito")
        {
            PolloFrito.gameObject.SetActive(false);
        }

        if (obj.tag == "restaurante")
        {
            restaurante.gameObject.SetActive(false);
        }

        if (obj.tag == "TiendaRegalos")
        {
            TiendaRegalos.gameObject.SetActive(false);
        }

        if (obj.tag == "bar")
        {
            bar.gameObject.SetActive(false);
        }

        if (obj.tag == "pizzeria")
        {
            pizzeria.gameObject.SetActive(false);
        }


        // Videos
        if (obj.tag == "cine")
        {
            videoRandom.SetActive(false);
        }
    }
}
