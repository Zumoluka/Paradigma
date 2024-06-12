using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameUI : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    public GameStateManager gameStateManager;

    private void Start()
    {

        gameStateManager.onStartGame.AddListener(StartGameUI);
        gameStateManager.onPauseGame.AddListener(PauseGameUI);
    }


    private void StartGameUI()
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(false);
    }


    private void PauseGameUI()
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(true);
    }
}
