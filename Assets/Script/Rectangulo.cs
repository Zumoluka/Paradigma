using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public TextMeshProUGUI textRectanculo;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        textRectanculo.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cubo = collision.GetComponent<Cubo>();
        if (cubo != null)
        {
            textRectanculo.gameObject.SetActive(true);  
            if (anim != null)
            {
                anim.SetTrigger("Saludo");
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        textRectanculo.gameObject.SetActive(true);
    }
}
