using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw_lot : MonoBehaviour
{
    public draw_lot instance;
    public List<Sprite> CharacterList;
    public List<Sprite> CoinList;
    public void Start()
    {
        instance = this;
    }
    public Sprite Start_Draw_lot(string type)
    {
        Sprite pickSprite;
        if (type.Equals("Character"))
        {
            pickSprite = CharacterList[UnityEngine.Random.Range(0, CharacterList.Count)];
        }
        else if (type.Equals("Coin"))
        {
            pickSprite = CoinList[UnityEngine.Random.Range(0, CoinList.Count)];
        }
        else
        {
            pickSprite = default;
        }

        return pickSprite;
    }

    
}
