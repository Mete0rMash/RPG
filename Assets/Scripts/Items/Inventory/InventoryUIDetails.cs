using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIDetails : MonoBehaviour
{
    ItemData item;
    Button selectedItemButton, itemInteractButton;
    Text itemNameText, itemDescriptionText, itemInteractButtonText;

    public Text statText;

    private void Start()
    {
        itemNameText = transform.Find("ItemName").GetComponent<Text>();
        itemDescriptionText = transform.Find("ItemDescription").GetComponent<Text>();
        itemInteractButton = transform.Find("Button").GetComponent<Button>();
        itemInteractButtonText = itemInteractButton.transform.Find("Text").GetComponent<Text>();
        gameObject.SetActive(false);
    }

    public void SetItem(ItemData item, Button selectedButton)
    {
        gameObject.SetActive(true);
        statText.text = "";

        if(item.stats != null)
        {
            foreach (BaseStat stat in item.stats)
            {
                statText.text += stat.StatName + ": " + stat.BaseValue + "\n";
            }
        }

        itemInteractButton.onClick.RemoveAllListeners();
        this.item = item;
        selectedItemButton = selectedButton;
        itemNameText.text = item.itemName;
        itemDescriptionText.text = item.itemDescription;
        itemInteractButtonText.text = item.itemActionName;
        itemInteractButton.onClick.AddListener(OnItemInteract);
    }

    public void OnItemInteract()
    {
        if(item.itemType == ItemData.ItemTypes.Consumable)
        {
            //InventoryController.Instance.ConsumeItem(item);
            Destroy(selectedItemButton.gameObject);
        }
        else if (item.itemType == ItemData.ItemTypes.Weapon)
        {
            InventoryController.Instance.EquipItem(item);
            Destroy(selectedItemButton.gameObject);
        }
        item = null;
        gameObject.SetActive(false);
    }
}
