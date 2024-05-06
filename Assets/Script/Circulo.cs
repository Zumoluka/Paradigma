using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public TextMeshProUGUI textcirculo;
    public TextMeshProUGUI textCubito;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        textCubito.gameObject.SetActive(false);
        textcirculo.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cubo = collision.GetComponent<Cubo>();
        if (cubo != null)
        {
            if (collision.gameObject.name == "Cubito")
            { 
                textCubito.gameObject.SetActive(true);
                Debug.Log("¡Hola Circulo!");
                if (anim != null)
                {
                    anim.SetTrigger("SaludoModificado");
                }
            }
            else
            {
                textcirculo.gameObject.SetActive(true);
                if (anim != null)
                {
                    anim.SetTrigger("SaludoAlternativo");
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        textCubito.gameObject.SetActive(false );
        textcirculo.gameObject.SetActive(false);
    }
}