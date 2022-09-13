using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermanentItem : BaseItem
{
    public override void OnPlayerCatch()
    {
        base.OnPlayerCatch();
    }

    public override bool IsConsumable()
    {
        return base.IsConsumable();
    }

    public override bool IsConsumable(bool value)
    {
        return base.IsConsumable(value);
    }
}
