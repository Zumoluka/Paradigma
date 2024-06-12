using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IPresentation
{
    public EnemyData enemyData;

    void IPresentation.Action()
    {
        Debug.Log(enemyData.saludo);
    }

}
