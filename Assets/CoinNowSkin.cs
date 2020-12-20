using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinNowSkin : MonoBehaviour
{
    string nowCoin;
    public List<Sprite> coin = new List<Sprite>();
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer[] coins = gameObject.GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < coin.Count; i++)
        {

            if (coin[i].name == DataController.instance.dataSave.nowCoin_name)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    coins[j].sprite = coin[i];
                }



            }
        }
    }

    
}
