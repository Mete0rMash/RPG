using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayableCharacter : Interactable
{
    private int ID;
    private string charName;

    public override void Interact()
    {
        Debug.Log("Interacting with NPC...");
    }
}
