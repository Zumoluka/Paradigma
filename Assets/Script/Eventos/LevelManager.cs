using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public UnityEvent onLevelChange;
    public int currentLevel = 1;


    public void ChangeLevel(int newLevel)
    {
        currentLevel = newLevel;

        onLevelChange.Invoke();
    }
}
