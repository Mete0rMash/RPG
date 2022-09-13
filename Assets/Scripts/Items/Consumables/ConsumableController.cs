using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableController : MonoBehaviour
{
    CharacterStats stats;

    private void Start()
    {
        stats = GetComponent<CharacterStats>();
    }

    public void ConsumeItem(ItemData item)
    {
        
    }
}
