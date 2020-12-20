using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManage : MonoBehaviour
{
    public GameObject soundOff;
    private void Start()
    {
        if (DataController.instance.dataSave.soundOn == true)
        {
            
            soundOff.SetActive(false);
        }
        else
        {
            soundOff.SetActive(true);
        }
    }
    public void SoundOnOff()
    {
  
        if (DataController.instance.dataSave.soundOn == true)
        {
            DataController.instance.dataSave.soundOn = false;
            soundOff.SetActive(true);
        }
        else
        {
            DataController.instance.dataSave.soundOn = true;
            soundOff.SetActive(false);
        }
    }
}
