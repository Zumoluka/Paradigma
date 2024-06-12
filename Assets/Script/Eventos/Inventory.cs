using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
public class Inventory : MonoBehaviour
{
    private List<GameObject> items = new List<GameObject>();

    public void AddItem(GameObject item)
    {
        items.Add(item);
        Debug.Log(item.name + " ha sido añadido al inventario.");
    }
}
