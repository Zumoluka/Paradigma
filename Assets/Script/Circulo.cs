using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public CanvasManager canvasManager;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cubo = collision.GetComponent<Cubo>();
        if (cubo != null)
        {
            if (collision.gameObject.name == "Cubito")
            { 
                collision.gameObject.name = "Circulo";
                Debug.Log("¡Hola Circulo!");
                if (anim != null)
                {
                    anim.SetTrigger("SaludoModificado");
                }
            }
            else
            {
                Debug.Log("¡Hola otro objeto!");
                if (anim != null)
                {
                    anim.SetTrigger("SaludoAlternativo");
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.OcultarCartel();
    }
}