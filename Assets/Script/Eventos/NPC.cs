using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    public UnityEvent onInteract;

    public void Interact()
    {

        onInteract.Invoke();
    }
}
