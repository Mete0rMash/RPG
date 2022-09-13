using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats
{
    public List<BaseStat> stats = new List<BaseStat>();

    public CharacterStats(float strength, float vitality, float dexterity)
    {
        stats = new List<BaseStat>()
        {
            new BaseStat(BaseStat.BaseStatType.Strength, strength, "Strength"),
            new BaseStat(BaseStat.BaseStatType.Vitality, vitality, "Vitality"),
            new BaseStat(BaseStat.BaseStatType.Dexterity, dexterity, "Dexterity")
        };

    }

    public BaseStat GetStat(BaseStat.BaseStatType stat)
    {
        return this.stats.Find(x => x.statType == stat);
    }

    public void AddStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat statBonus in statBonuses)
        {
            GetStat(statBonus.statType).AddStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

    public void RemoveStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat statBonus in statBonuses)
        {
            GetStat(statBonus.statType).RemoveStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }
}
