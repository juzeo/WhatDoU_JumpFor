using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clearPanel : MonoBehaviour
{
    private void Start()
    {
        Text coinText = GameObject.Find("Money").GetComponent<Text>();
        coinText.text = CoinManager.instance.thisGameCoin.ToString();
    }

    public void showAds()
    {

    }
    public void NextStage()
    {
       GameManage.instance.Next();
    }
    
}
