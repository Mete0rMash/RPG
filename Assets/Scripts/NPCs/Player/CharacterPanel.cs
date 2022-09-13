using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPanel : MonoBehaviour
{
    [SerializeField] private Text health, level;
    [SerializeField] private Player player;

    void Start()
    {
        UIEventHandler.OnPlayerHealthChanged += UpdateHealth;
    }

    void UpdateHealth(float currentHealth, float maxHealth)
    {
        this.health.text = currentHealth.ToString();
    }
}
