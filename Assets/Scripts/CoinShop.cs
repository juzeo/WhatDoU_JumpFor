using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinShop : MonoBehaviour
{
    public void coin100()
    {
        CoinManager.instance.InCoin(100);
    }
    public void coin200()
    {
        CoinManager.instance.InCoin(200);
    }
    public void coin300()
    {
        CoinManager.instance.InCoin(300);
    }
    public void coin400()
    {
        CoinManager.instance.InCoin(400);
    }
    public void coin500()
    {
        CoinManager.instance.InCoin(500);
    }
    public void coin1000()
    {
        CoinManager.instance.InCoin(1000);
    }
}
