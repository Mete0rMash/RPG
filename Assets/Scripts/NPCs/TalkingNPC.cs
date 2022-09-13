using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingNPC : Interactable
{
    public string[] dialogue;
    public string c_name;

    public override void Interact()
    {
        DialogueManager.Instance.AddNewDialogue(dialogue, c_name);
    }
}
