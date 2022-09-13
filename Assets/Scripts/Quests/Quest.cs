using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Quest : MonoBehaviour
{
    public List<Objective> objectiveList { get; set; }
    public string questName { get; set; }
    public string description { get; set; }
    public ItemData itemReward { get; set; }
    public bool completed { get; set; }

    public void CheckGoals()
    {
        completed = objectiveList.All(o => o.Completed);
    }

    public void GiveReward()
    {
        if(itemReward != null)
        {
            InventoryController.Instance.GiveItem(itemReward);
        }
    }
}
