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
    public List<Sprite> AbleList;
    public Transform result;
    public void Start()
    {
        instance = this;
        AbleList = Drawing_lot_Able_Character.instance.Able_Img_List;
        Sprite resultImg = Start_Draw_lot(Drawing_lot_Able_Character.instance.Drawing_Type);
        result.GetComponent<Image>().sprite = resultImg;
        result.gameObject.SetActive(true);
        Drawing_lot_Able_Character.instance.GetCharacter = resultImg;

    }
    public Sprite Start_Draw_lot(string type)
    {
        Sprite pickSprite;
        if (type.Equals("Character"))
        {
            pickSprite = AbleList[UnityEngine.Random.Range(0, AbleList.Count)];
        }
        else if (type.Equals("Coin"))
        {
            pickSprite = AbleList[UnityEngine.Random.Range(0, AbleList.Count)];
        }
        else
        {
            pickSprite = default;
        }

        return pickSprite;
    }

    
}
