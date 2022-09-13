using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    List<Quest> mainQuests;
    List<Quest> sideQuests;
    List<Quest> completedQuests;
    int questControllerID;
    int actualMainQuest;
    int playerID;

    void AddMainQuest()
    {

    }

    void AddSideQuest()
    {

    }

    void RemoveMainQuest()
    {

    }

    void RemoveSideQuest()
    {

    }

    Quest GetMainQuest()
    {
        return mainQuests[actualMainQuest];
    }

    void IncrementActualMainQuest()
    {
        actualMainQuest++;
    }

    private void Start()
    {
        QuestManager.instance.LinkPlayer(playerID, this);
    }
}
