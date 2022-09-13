using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    GameQuestData mainQuest;
    GameQuestData sideQuest;

    public static QuestManager instance;

    Dictionary<int, QuestController> playerQuests = new Dictionary<int, QuestController>();

    /*public QuestManager GetInstance()
    {
        return instance;
    }*/

    void SendMessage(int questController, string objective)
    {

    }

    public void LinkPlayer(int id, QuestController questController)
    {
        if(!playerQuests.ContainsKey(id) && !playerQuests.ContainsValue(questController))
        {
            playerQuests.Add(id, questController);
        }
    }

    void LoadMainQuest()
    {
        TextAsset jsonTxt = Resources.Load<TextAsset>("mainQuests");
        mainQuest = JsonUtility.FromJson<GameQuestData>(jsonTxt.text);
    }

    void LoadSideQuest()
    {
        TextAsset jsonTxt = Resources.Load<TextAsset>("sideQuests");
        sideQuest = JsonUtility.FromJson<GameQuestData>(jsonTxt.text);
    }
}
