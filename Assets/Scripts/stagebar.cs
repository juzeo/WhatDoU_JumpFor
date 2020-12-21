using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stagebar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        gameObject.transform.GetComponent<Text>().text = DataController.instance.dataSave.nowStage+"F";
    }

   
}
