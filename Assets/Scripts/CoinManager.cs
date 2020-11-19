using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public int coin=0;
    void Awake()
    {


        if (instance != null)
        {
            Destroy(gameObject);
        }else
        instance = this;
        DontDestroyOnLoad(this.gameObject);
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
    }
    public bool OutCoin(int num)
    {
        if (coin >= num)
        {
            coin -= num;
            return true;
        }
        else return false;
    }
    public int getCoin()
    {
        return coin;
    }
}
