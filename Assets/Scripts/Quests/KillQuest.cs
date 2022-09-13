using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillQuest : Quest
{
    void Start()
    {
        questName = "Killing Bichitos";
        description = "Kill all the Bichitos";
        itemReward = lvlController.Instance.GetItem("sword");

        objectiveList = new List<Objective>
        {
            new KillGoal(this, 0, "Kill 5 Bichitos", false, 0, 5)
        };

        objectiveList.ForEach(g => g.Init());
    }
}
