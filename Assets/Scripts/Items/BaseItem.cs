using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : Interactable
{
    public ItemData itemData;

    void Start()
    {
        //GameItemData gid = FindObjectOfType<lvlController>().itemsData;
        //this.itemData.CopyInfo(gid.arItemData[itemData.ID], UID.GetUniqueID(), );
    }


    public override void Interact()
    {
        base.Interact();
    }

    public virtual void OnPlayerCatch()
    {

    }

    public virtual bool IsConsumable()
    {
        return false;
    }

    public virtual bool IsConsumable(bool value)
    {
        return false;
    }
}
