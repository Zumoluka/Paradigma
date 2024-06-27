using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Health { get; set; }

    public Enemy_(string name, string type, int health)
    {
        Name = name;
        Type = type;
        Health = health;
    }

}
