using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class BaseStat
{
    public enum BaseStatType { Strength, Vitality, Dexterity}

    public List<StatBonus> BaseAdditives { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public BaseStatType statType { get; set; }

    public float BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription { get; set; }
    public float FinalValue { get; set; }

    public BaseStat(int baseValue, string statName, string statDescription)
    {
        this.BaseAdditives = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statDescription;
    }

    [Newtonsoft.Json.JsonConstructor]
    public BaseStat(BaseStatType statType, float baseValue, string statName)
    {
        this.BaseAdditives = new List<StatBonus>();
        this.statType = statType;
        this.BaseValue = baseValue;
        this.StatName = statName;
    }

    public void AddStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Add(statBonus);
    }

    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(BaseAdditives.Find(x => x.BonusValue == statBonus.BonusValue));
    }

    public float GetCalculatedStatValue()
    {
        this.FinalValue = 0;
        this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue);
        FinalValue += BaseValue;
        return FinalValue;
    }
}
