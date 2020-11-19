using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopBtn : MonoBehaviour
{
    public GameObject CharacterScroll;
    public GameObject CoinScroll;
    public Image CoinBtnImg;
    public Image CharacterBtnImg;
    public Text Play;

    public void CharacterBtn()
    {
        CharacterScroll.SetActive(true);
        Color color;
        ColorUtility.TryParseHtmlString("#CFCFCF", out color);
        CharacterBtnImg.color = color;
        CoinScroll.SetActive(false);
        ColorUtility.TryParseHtmlString("#FFFFFF", out color);
        CoinBtnImg.color = color;

    }
    public void CoinBtn()
    {
        CharacterScroll.SetActive(false);
        Color color;
        ColorUtility.TryParseHtmlString("#FFFFFF", out color);
        CharacterBtnImg.color = color;
        CoinScroll.SetActive(true);
        ColorUtility.TryParseHtmlString("#CFCFCF", out color);

        CoinBtnImg.color = color;
    }
    public void PlayBtn()
    {
        if (Play.text.Equals("X")){

        }
        else
        {
            SceneManager.LoadScene("main");
        }
    }
    public void MoveDarwing_Lot()
    {
        if (CoinManager.instance.OutCoin(100))//코인 100개 소모
        {
            GameObject[] Coins = GameObject.FindGameObjectsWithTag("Coin"); //코인 테그 오브젝트 찾기
            if (Coins[0].transform.parent.name == "CoinScroll")//부모에따라 코인과 캐릭터로 분류
            {
                Drawing_lot_Able_Character.instance.Drawing_Type = "Coin";
            }
            else
            {
                Drawing_lot_Able_Character.instance.Drawing_Type = "Character";
            }
            List<Sprite> Coins_Sprite = new List<Sprite>();
            for (int i = 0; i < Coins.Length; i++)
            {
                if (Coins[i].GetComponent<Item_UnLock>().Unlcok == false)//만약 잠금 상태라면
                {
                    Coins_Sprite.Add(Coins[i].GetComponent<SpriteRenderer>().sprite);//뽑기 목록에 추가
                }

            }
            Drawing_lot_Able_Character.instance.Able_Img_List = new List<Sprite>();
            Drawing_lot_Able_Character.instance.Able_Img_List = Coins_Sprite;

            SceneManager.LoadScene("drawing lots");
        }
        
        
    }
}
