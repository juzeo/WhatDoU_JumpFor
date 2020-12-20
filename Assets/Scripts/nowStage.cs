using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nowStage : MonoBehaviour
{
    public static nowStage instance;
    int stage;
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            stage = DataController.instance.dataSave.nowStage;
        }


    }
    public void Upstage()
    {
        stage++;
        DataController.instance.dataSave.nowStage = stage;
    }

    public int getStage()
    {
        return stage;
    }
}
