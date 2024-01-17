using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameEventSystem : MonoBehaviour
{
    public static GameEventSystem instance;

    private GameEventSystem() { }

    private void Awake()
    {
        instance = this;
    }

    public event Action OnPlayerDead;

    public void PlayerDead()
    {
        if (OnPlayerDead != null)
        {
            OnPlayerDead();
        }
    }



}
