using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinManager : MonoBehaviour
{
    public GameObject Player;
    public static CoinManager instance;

    public int coin;
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
            coin = DataController.instance.dataSave.Coin;
            Coinbar.instance.UpdateText();

        }
     
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            InCoin(100);
        }
    }

    public void InCoin(int num)
    {
        coin += num;
        DataController.instance.dataSave.Coin = coin;
        Coinbar.instance.UpdateText();
        Debug.Log("코인 저장");
    }
    public bool OutCoin(int num)
    {
        if (coin >= num)
        {
            coin -= num;
            DataController.instance.dataSave.Coin = coin;
            Coinbar.instance.UpdateText();
            Debug.Log("코인 저장");
            return true;
        }
        else return false;
    }
    public int getCoin()
    {
        return coin;
    }

 
}
