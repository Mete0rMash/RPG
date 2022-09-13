using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour
{
    public ItemData item;

    public Text itemText;
    public Image itemImage;

    public void SetItem(ItemData item)
    {
        this.item = item;
        SetupItemValues();
    }

    void SetupItemValues()
    {
        itemText.text = item.itemName;
        itemImage.sprite = Resources.Load<Sprite>("UI/Icons/Items/" + item.nameCode);
    }

    public void OnSelectItemButton()
    {
        InventoryController.Instance.SetItemDetails(item, GetComponent<Button>());
    }
}
