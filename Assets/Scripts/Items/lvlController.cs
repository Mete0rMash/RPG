using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class lvlController : MonoBehaviour
{
	public static lvlController Instance { get; set; }

	private List<ItemData> Items { get; set; }

	private void Awake()
    {
		if (Instance != null && Instance != this) Destroy(gameObject);
		else Instance = this;

        ReadItemJSON();
    }

	void ReadItemJSON()
	{
		TextAsset jsonTxt = Resources.Load<TextAsset>("itemStats");

		Items = JsonConvert.DeserializeObject<List<ItemData>>(jsonTxt.text);

		Debug.Log(Items[0].stats[0].StatName + " level is " + Items[0].stats[0].GetCalculatedStatValue());
		Debug.Log(Items[0].itemName);
	}

	public ItemData GetItem(string _nameCode)
    {
		foreach(ItemData item in Items)
        {
            if (item.nameCode == _nameCode)
            {
				return item;
            }
        }
		return null;
    }
}
