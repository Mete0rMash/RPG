﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoal : Objective
{
    public int EnemyID { get; set; }

    public KillGoal(Quest quest, int enemyID, string description, bool completed, int currentAmount, int RequiredAmount)
    {
        this.Quest = quest;
        this.EnemyID = enemyID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = RequiredAmount;
    }

    public override void Init()
    {
        base.Init();
        CombatEvents.OnEnemyDeath += EnemyDied;
    }

    void EnemyDied(IEnemy enemy)
    {
        if (enemy.ID == this.EnemyID)
        {
            Debug.Log("Detected enemy death: " + EnemyID);
            this.CurrentAmount++;
            Evaluate();
        }
    }
}
