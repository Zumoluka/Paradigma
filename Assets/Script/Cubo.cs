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
        float speed_x = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(speed_x * velocidad * Time.deltaTime, 0f, 0f));
    }
}
