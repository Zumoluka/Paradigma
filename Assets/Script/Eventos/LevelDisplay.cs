using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelDisplay : MonoBehaviour
{
    public Text levelText;
    public LevelManager levelManager;

    private void Start()
    {

        levelManager.onLevelChange.AddListener(UpdateLevelText);

        UpdateLevelText();
    }


    private void UpdateLevelText()
    {
        levelText.text = "Nivel: " + levelManager.currentLevel.ToString();
    }
}
