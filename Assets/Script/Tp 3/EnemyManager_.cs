using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyManager_ : MonoBehaviour
{
    private List<Enemy_> enemies;

    void Start()
    {
        enemies = new List<Enemy_>
        {
            new Enemy_("Zombie1", "Zombie", 100),
            new Enemy_("Alien1", "Alien", 150),
            new Enemy_("Robot1", "Robot", 200),
            new Enemy_("Zombie2", "Zombie", 120),
            new Enemy_("Alien2", "Alien", 180),
            new Enemy_("Robot2", "Robot", 220)
        };
        var groupedEnemies = enemies.GroupBy(e => e.Type);

        foreach (var group in groupedEnemies)
        {
            Debug.Log($"Tipo de Enemigo: {group.Key}");
            foreach (var enemy in group)
            {
                Debug.Log($"  Nombre: {enemy.Name}, Salud: {enemy.Health}");
            }
        }
    }
}
