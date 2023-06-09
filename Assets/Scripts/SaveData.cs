using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData : MonoBehaviour
{
    [SerializeField] private PlayerData m_PlayerData;

    public void SaveIntoJson()
    {
        m_PlayerData.Save();
        string playerDataJson = JsonUtility.ToJson(m_PlayerData);
        // string filePath = Application.persistentDataPath + "/playerdata.json";
        // Debug.Log(filePath);

        if (!File.Exists(Application.persistentDataPath + "/playerdata.save"))
        {
            File.Create(Application.persistentDataPath + "/playerdata.save").Dispose();
        }
        File.WriteAllText(Application.persistentDataPath + "/playerdata.save", playerDataJson);
    }

    public void LoadFile()
    {
        Debug.Log(Application.persistentDataPath + "/playerdata.save");

        if(File.Exists(Application.persistentDataPath + "/playerdata.save"))
        {
            string loadDataJson = File.ReadAllText(Application.persistentDataPath + "/playerdata.save");
            m_PlayerData = JsonUtility.FromJson<PlayerData>(loadDataJson);
            m_PlayerData.Load();
        }
        else
        {
            m_PlayerData = new PlayerData();
        }
    }
}

[System.Serializable]
public class PlayerData
{
    public Vector3 playerPosition;
    public int playerScore;
    public int playerLevel;

    public void Save()
    {
        playerPosition = PlayerMovement.instance.gameObject.transform.position;
        Debug.Log(playerPosition);
    }

    public void Load()
    {
        PlayerMovement.instance.gameObject.transform.position = playerPosition;
    }
}