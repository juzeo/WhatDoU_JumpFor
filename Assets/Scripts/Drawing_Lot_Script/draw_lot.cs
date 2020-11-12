using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class draw_lot : MonoBehaviour
{
    public draw_lot instance;
    public List<Sprite> CharacterList;
    public List<Sprite> CoinList;
    public Transform result;
    public void Start()
    {
        instance = this;
        result.GetComponent<Image>().sprite = Start_Draw_lot("Coin");
        result.gameObject.SetActive(true);

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
