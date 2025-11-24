using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColision : MonoBehaviour
{
    public AudioSource reproductor;
    public AudioClip selectNoise;
    public Image bowlFrutas;

    void Start()
    {
        bowlFrutas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "fruteria")
        {
            bowlFrutas.gameObject.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider obj)
    {
        if(obj.tag == "fruteria")
        {
            bowlFrutas.gameObject.SetActive(false);
        }
    }
}
