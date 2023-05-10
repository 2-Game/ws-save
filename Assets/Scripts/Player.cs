using System;
using UnityEngine;

[Serializable]
public class PlayerInfo
{
    public string pseudo = "Patrick";
    public PlayerStats stats;
    public Vector3 position;
}

[Serializable]
public class PlayerStats
{
    public int force;
    public int lvl;
    public int money;
}

public class Player : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
