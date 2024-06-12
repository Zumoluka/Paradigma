using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    public UnityEvent onStartGame;
    public UnityEvent onPauseGame;


    public void StartGame()
    {

        onStartGame.Invoke();
    }


    public void PauseGame()
    {

        onPauseGame.Invoke();
    }
}
