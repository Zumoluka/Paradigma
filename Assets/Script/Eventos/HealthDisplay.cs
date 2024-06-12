using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HealthDisplay : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public PlayerHealth playerHealth;

    private void Start()
    {

        playerHealth.onHealthChange.AddListener(UpdateHealthText);

        UpdateHealthText();
    }


    private void UpdateHealthText()
    {
        healthText.text = "Salud: " + playerHealth.health.ToString();
    }
}
