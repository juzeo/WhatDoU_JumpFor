using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinbar : MonoBehaviour
{
    public static Coinbar instance;
    Text CoinbarText;
    void Start()
    {
        instance = this;
        CoinbarText = gameObject.GetComponent<Text>();
       
        CoinbarText.text=CoinManager.instance.getCoin().ToString();
    }

    
}
