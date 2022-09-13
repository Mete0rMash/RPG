using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(gameObject);

        else Instance = this;
    }

    public GameObject player;
}
