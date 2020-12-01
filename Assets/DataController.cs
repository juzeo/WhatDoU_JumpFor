using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    public static DataController instance;
    public DataSave dataSave;


    public string DataFileName = "Coin.json";
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(Application.persistentDataPath);
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        LoadData();
        SaveData();
    }
    public void SaveData()
    {
        string ToJsonData = JsonUtility.ToJson(dataSave);
        string filePath = Application.persistentDataPath + DataFileName;
        File.WriteAllText(filePath, ToJsonData);


    }
    public void LoadData()
    {
        string filePath = Application.persistentDataPath + DataFileName;

        if (File.Exists(filePath))
        {
            
            string FromJson = File.ReadAllText(filePath);
            dataSave = JsonUtility.FromJson<DataSave>(FromJson);
            Debug.Log("불러오기");
            
            
        }
        else
        {
            Debug.Log("파일 생성");
            dataSave = new DataSave();
        }
        
    }
    private void OnApplicationQuit()
    {
        SaveData();
        Debug.Log("저장");
        


    }
}
