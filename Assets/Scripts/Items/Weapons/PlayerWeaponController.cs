using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public GameObject EquippedWeapon { get; set; }

    ItemData currentlyEquippedItem;
    IWeapon equippedWeapon;
    CharacterStats characterStats;

    private void Start()
    {
        characterStats = GetComponent<Player>().characterStats;
    }

    public void EquipWeapon(ItemData itemToEquip)
    {
        if (EquippedWeapon != null)
        {
            UnequipWeapon();
        }

        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.nameCode));

        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
        equippedWeapon.Stats = itemToEquip.stats;
        currentlyEquippedItem = itemToEquip;
        characterStats.AddStatBonus(itemToEquip.stats);
        UIEventHandler.ItemEquipped(itemToEquip);
        UIEventHandler.StatsChanged();
    }

    public void UnequipWeapon() 
    {
        InventoryController.Instance.GiveItem(currentlyEquippedItem.nameCode);
        characterStats.RemoveStatBonus(equippedWeapon.Stats);
        Destroy(EquippedWeapon.transform.gameObject);
        UIEventHandler.StatsChanged();
    }

    
}
