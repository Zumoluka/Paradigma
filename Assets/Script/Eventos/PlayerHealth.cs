using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public UnityEvent onHealthChange;


    public void UpdateHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, 100);

        onHealthChange.Invoke();
    }
}
