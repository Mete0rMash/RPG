using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventHandler : MonoBehaviour
{
    public delegate void ItemEventHandler(ItemData item);
    public static event ItemEventHandler OnItemAddedToInventory;
    public static event ItemEventHandler OnItemEquipped;

    public delegate void PlayerHealthEventHandler(float currentHealth, float maxHealth);
    public static event PlayerHealthEventHandler OnPlayerHealthChanged;

    public delegate void StatsEventHandler();
    public static event StatsEventHandler OnStatsChanged;

    public delegate void PlayerLevelEventHandler();
    public static event PlayerLevelEventHandler OnPlayerLevel;

    public static void ItemAddedToInventory(ItemData item)
    {
        if (OnItemAddedToInventory != null)
            OnItemAddedToInventory(item);
    }
    public static void ItemAddedToInventory(List<ItemData> items)
    {
        if (OnItemAddedToInventory != null)
        {
            foreach (ItemData item in items)
            {
                OnItemAddedToInventory(item);
            }
        }
    }

    public static void ItemEquipped(ItemData item)
    {
        if (OnItemEquipped != null)
            OnItemEquipped(item);
    }

    public static void HealthChanged(float currentHealth, float maxHealth)
    {
        if (OnPlayerHealthChanged != null)
            OnPlayerHealthChanged(currentHealth, maxHealth);
    }

    public static void StatsChanged()
    {
        if (OnStatsChanged != null)
            OnStatsChanged();
    }
}
