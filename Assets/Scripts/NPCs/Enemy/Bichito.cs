using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bichito : Interactable, IEnemy
{
    public LayerMask aggroLayer;
    public float currentHealth;
    public float maxHealth;

    [SerializeField]private Player player;
    private NavMeshAgent navAgent;
    private CharacterStats characterStats;
    private Collider[] withinAggroColliders;

    public int ID { get; set; }

    private void Start()
    {
        ID = 0;
        navAgent = GetComponent<NavMeshAgent>();
        characterStats = new CharacterStats(1, 10, 0.7f);
        maxHealth = characterStats.GetStat(BaseStat.BaseStatType.Vitality).GetCalculatedStatValue();
        currentHealth = maxHealth;
    }

    private void FixedUpdate()
    {
        withinAggroColliders = Physics.OverlapSphere(transform.position, 10, aggroLayer);

        if (withinAggroColliders.Length > 0)
        {
            ChasePlayer(withinAggroColliders[0].GetComponent<Player>());
        }
    }

    public override void Interact()
    {
        if(player != null)
        {
            TakeDamage(player.Attack());
        }
    }

    public void PerformAttack()
    {
        float damage = characterStats.GetStat(BaseStat.BaseStatType.Strength).GetCalculatedStatValue();
        player.TakeDamage(damage);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void ChasePlayer(Player player)
    {
        navAgent.SetDestination(player.transform.position);
        this.player = player;

        if (navAgent.remainingDistance <= navAgent.stoppingDistance)
        {
            if(!IsInvoking("PerformAttack"))
            InvokeRepeating("PerformAttack", .5f, 2f);
        }
        else
        {
            CancelInvoke("PerformAttack");
        }
    }

    public void Die()
    {
        CombatEvents.EnemyDied(this);
        Destroy(gameObject);
    }
}
