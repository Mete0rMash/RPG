using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    private Stage unable, intro, onGoing, finished;
    private Stage actualStage;

    Stage GetActualStage()
    {
        return actualStage;
    }

    void SetStage(string newStage)
    {
        switch (newStage)
        {
            case "unable":
                actualStage = unable;
                break;
            case "intro":
                actualStage = intro;
                break;
            case "onGoing":
                actualStage = onGoing;
                break;
            case "finished":
                actualStage = finished;
                break;
        }
    }
}
