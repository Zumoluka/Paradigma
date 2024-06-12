using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{
    public UnityEvent onCollected;


    public void Collect()
    {

        onCollected.Invoke();

        Destroy(gameObject);
    }
}
