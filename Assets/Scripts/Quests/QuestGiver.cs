using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : TalkingNPC
{
    public bool AssignedQuest { get; set; }
    public bool Helped { get; set; }

    [SerializeField]
    private GameObject quests;

    [SerializeField]
    private string questType;
    private Quest Quest { get; set; }

    public override void Interact()
    {

        if (!AssignedQuest && !Helped)
        {
            base.Interact();
            AssignQuest();
        }
        else if (AssignedQuest && !Helped)
        {
            CheckQuest();
        }
        else
        {
            DialogueManager.Instance.AddNewDialogue(new string[] { "Thanks for helping me that time." }, DialogueManager.Instance.npcName);
        }
    }

    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));
    }

    void CheckQuest()
    {
        if (Quest.completed)
        {
            Quest.GiveReward();
            Helped = true;
            AssignedQuest = false;
            DialogueManager.Instance.AddNewDialogue(new string[] { "Thanks for that! Here's your reward."}, DialogueManager.Instance.npcName);
        }
        else
        {
            DialogueManager.Instance.AddNewDialogue(new string[] { "You're still in the middle of helping me. Get back at it!" }, DialogueManager.Instance.npcName);
        }
    }
}
