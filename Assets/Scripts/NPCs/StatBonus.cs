using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StatBonus
{
    public float BonusValue { get; set; }
    public StatBonus(float bonusValue)
    {
        this.BonusValue = bonusValue;
    }
}
