using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public enum ItemTypes { Weapon, Consumable, Quest, Equipment}
    public string itemName { get; set; }
    public string itemDescription { get; set; }
    public string itemActionName { get; set; }
    public string nameCode { get; set; }
    public ItemTypes itemType { get; set; }
    string uID { get; set; }
    public bool itemModifier { get; set; }
    public List<BaseStat> stats { get; set; }

    public ItemData(List<BaseStat> _stats, string _nameCode)
    {
        this.stats = _stats;
        this.nameCode = _nameCode;
    }

    [Newtonsoft.Json.JsonConstructor]
    public ItemData(List<BaseStat> _stats, string _nameCode, string _description, string _ActionName, string _ItemName, bool _itemModifier)
    {
        this.stats = _stats;
        this.nameCode = _nameCode;
        this.itemDescription = _description;
        this.itemActionName = _ActionName;
        this.itemName = _ItemName;
        this.itemModifier = _itemModifier;
    }
}
