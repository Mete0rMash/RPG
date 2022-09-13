using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance { get; set; }

    public PlayerWeaponController playerWeaponController;

    public InventoryUIDetails inventoryDetailsPanel;

    public List<ItemData> playerItems = new List<ItemData>();

    private void Start()
    {
        if (Instance != null && Instance != this) Destroy(gameObject);

        else Instance = this;

        playerWeaponController = GetComponent<PlayerWeaponController>();
    }

    public void GiveItem(string nameCode)
    {
        ItemData item = lvlController.Instance.GetItem(nameCode);
        playerItems.Add(item);

        UIEventHandler.ItemAddedToInventory(item);
    }

    public void GiveItem(ItemData item)
    {
        playerItems.Add(item);
        UIEventHandler.ItemAddedToInventory(item);
    }

    public void GiveItem(List<ItemData> items)
    {
        playerItems.AddRange(items);
        UIEventHandler.ItemAddedToInventory(items);
    }

    public void SetItemDetails(ItemData item, Button selectedButton)
    {
        inventoryDetailsPanel.SetItem(item, selectedButton);
    }

    public void EquipItem(ItemData itemToEquip)
    {
        playerWeaponController.EquipWeapon(itemToEquip);
    }
}
