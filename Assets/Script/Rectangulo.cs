using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
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
            Debug.Log("¡Hola " + collision.gameObject.name + "!");
            if (anim != null)
            {
                anim.SetTrigger("Saludo");
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.OcultarCartel();
    }
}
