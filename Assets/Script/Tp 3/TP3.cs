using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TP3 : MonoBehaviour
{
    public Action<GameObject> OnCollisionEnterAction;

    void Start()
    {
        OnCollisionEnterAction = (collisionObject) =>
        {
            Debug.Log("Colisionó con: " + collisionObject.name);
        };
    }

    void OnCollisionEnter(Collision collision)
    {
        OnCollisionEnterAction?.Invoke(collision.gameObject);
    }
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var numerosPares = from numero in numeros
                           where numero % 2 == 0
                           select numero;

        var numerosParesLambda = numeros.Where(n => n % 2 == 0);

        Console.WriteLine("Números pares:");
        foreach (var num in numerosPares)
        {
            Console.WriteLine(num);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
