using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IPresentation, ITakeDamage
{
    public EnemyData enemyData;

    void IPresentation.Action()
    {
        Debug.Log(enemyData.saludo);
    }
    public void TakeDamage(int amount)
    {
        enemyData.vida -= amount;
        Debug.Log($"{enemyData.nombre} recibió {amount} de daño. Vida restante: {enemyData.vida}");
    }
}
