using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinbar : MonoBehaviour
{
    public static Coinbar instance;
    public Text CoinbarText;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
       
        CoinbarText = gameObject.GetComponent<Text>();

        CoinbarText.text=DataController.instance.dataSave.Coin.ToString();
   
    }



    public void UpdateText()
    {
        CoinbarText.text = CoinManager.instance.getCoin().ToString();
    }

    
}
