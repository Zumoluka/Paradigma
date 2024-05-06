using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tienda espadaDeHierro = new Tienda();
        espadaDeHierro.Nombre = "Espada de Hierro";
        espadaDeHierro.Precio = 1.5f;

        Tienda escudoDeMadera = new Tienda();
        escudoDeMadera.Nombre = "Escudo de Madera";
        escudoDeMadera.Precio = 0.5f;

        Tienda pistolaPewPew = new Tienda();
        pistolaPewPew.Nombre = "Pistola:Pew-Pew";
        pistolaPewPew.Precio = 9999f;

        
        Debug.Log("Producto: " + espadaDeHierro.Nombre + " | Precio: " + espadaDeHierro.Precio.ToString("C"));
        Debug.Log("Producto: " + escudoDeMadera.Nombre + " | Precio: " + escudoDeMadera.Precio.ToString("C"));
        Debug.Log("Producto: " + pistolaPewPew.Nombre + " | Precio: " + pistolaPewPew.Precio.ToString("C"));
    
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
