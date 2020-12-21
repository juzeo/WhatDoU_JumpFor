using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        SceneManager.LoadScene("Scenes/Stages/Stage" + DataController.instance.dataSave.nowStage);

    }

  
}
