using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PlayerData
{
    public Vector3 playerPosition;
    public int playerScore;
    public int playerLevel;
}

public class SaveData : MonoBehaviour
{
    [SerializeField] private PlayerData m_PlayerData = new PlayerData();

    public void SaveIntoJson()
    {
        string playerDataJson = JsonUtility.ToJson(m_PlayerData);
        Debug.Log(playerDataJson);

        if (!File.Exists(Application.persistentDataPath + "/playerdata.save"))
        {
            File.Create(Application.persistentDataPath + "/playerdata.save").Dispose();
        }
        File.WriteAllText(Application.persistentDataPath + "/playerdata.save", playerDataJson);
    }

    protected void LoadFile()
    {
        Debug.Log(Application.persistentDataPath + "/playerdata.save");

        if(File.Exists(Application.persistentDataPath + "/playerdata.save"))
        {
            string loadDataJson = File.ReadAllText(Application.persistentDataPath + "/playerdata.save");
            m_PlayerData = JsonUtility.FromJson<PlayerData>(loadDataJson);
        }
        else
        {
            m_PlayerData = new PlayerData();
        }
    }
}
