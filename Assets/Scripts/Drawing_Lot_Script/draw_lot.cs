using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class draw_lot : MonoBehaviour
{
    public static draw_lot instance;
    public List<Sprite> CharacterList;
    public List<Sprite> CoinList;
    public List<Sprite> AbleList;
    public Transform result;
    public Transform backBtn;
    public GameObject box;
    Animation boxAnim;
    public void Start()
    {
        instance = this;
        AbleList = Drawing_lot_Able_Character.instance.Able_Img_List;
        
        
    }
    public void Start_Draw_lot(string type)
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
            result.GetComponent<Image>().sprite = pickSprite;
        box.SetActive(false);
        backBtn.gameObject.SetActive(true);
        result.GetComponent<RectTransform>().sizeDelta = pickSprite.rect.size*2;
            result.gameObject.SetActive(true);
         Drawing_lot_Able_Character.instance.GetCharacter = pickSprite;
            
        
    }



       

    
}
