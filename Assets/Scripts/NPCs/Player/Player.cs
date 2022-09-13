using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterStats characterStats;
    public float currentHealth;
    public float maxHealth;

    PlayerWeaponController weaponController;


    private void Start()
    {
        characterStats = new CharacterStats(4, 20, 1.2f);
        maxHealth = characterStats.GetStat(BaseStat.BaseStatType.Vitality).GetCalculatedStatValue();
        this.currentHealth = this.maxHealth;
        UIEventHandler.HealthChanged(this.currentHealth, this.maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
        UIEventHandler.HealthChanged(this.currentHealth, this.maxHealth);
    }

    void Die()
    {

    }

    public float Attack()
    {
        float damage = CalculateDamage();

        return damage;
    }

    private float CalculateDamage()
    {
        float damageToDeal = characterStats.GetStat(BaseStat.BaseStatType.Strength).GetCalculatedStatValue() + Random.Range(-2, 2);

        damageToDeal += CalculateCrit(damageToDeal);
        return damageToDeal;
    }

    private float CalculateCrit(float damage)
    {
        if (Random.value <= .05f)
        {
            int critDamage = (int)(damage * .5f);
            return critDamage;
        }

        return 0;
    }
}
