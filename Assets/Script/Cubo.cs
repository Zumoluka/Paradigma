using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float velocidad;
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                Debug.LogWarning("El nombre no puede ser nulo o vacío.");
            }
        }
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical) * velocidad * Time.deltaTime;
        transform.Translate(movimiento);
    }
}
