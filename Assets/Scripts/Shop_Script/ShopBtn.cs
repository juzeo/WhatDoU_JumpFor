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
    public List<Transform> ItemList;
    public Character_Selecter CoinSelecter;
    public Character_Selecter CharacterSelecter;


    public void Start()
    {
        List<CharacterNCoin> UnlockList = DataController.instance.dataSave.UnlockList;
        for (int i = 0; i < ItemList.Count; i++)
        {
            for (int j = 0; j < UnlockList.Count; j++)
            {
                if (UnlockList[j].name== ItemList[i].GetComponent<SpriteRenderer>().sprite.name) 
                {
                    ItemList[i].GetComponent<Item_UnLock>().Unlcok = UnlockList[j].Unlock;
                }
            }
           
        }
    }
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
        SaveItemList();
        GameObject Coin = GameObject.FindGameObjectWithTag("Coin");
        Debug.LogError(Coin.transform.parent.parent.name);
        if (Coin.transform.parent.parent.name == "CoinScroll")
        {
            for (int i = 0; i < DataController.instance.dataSave.UnlockList_name.Count; i++)
            {
               // Debug.LogError(Selecter.GetNowCharacter()+ DataController.instance.dataSave.UnlockList_name[i]);
                if (CoinSelecter.GetNowCharacter() == DataController.instance.dataSave.UnlockList_name[i])
                {
                   
                    if (DataController.instance.dataSave.UnlockList_bool[i] == true)
                    {
                       
                        DataController.instance.dataSave.nowCoin_name = CoinSelecter.GetNowCharacter();
                    }
                }
            }
           
        }
        else
        {
            for (int i = 0; i < DataController.instance.dataSave.UnlockList_name.Count; i++)
            {
                if (CharacterSelecter.GetNowCharacter() == DataController.instance.dataSave.UnlockList_name[i])
                {
                    if (DataController.instance.dataSave.UnlockList_bool[i] == true)
                    {
                    
                        DataController.instance.dataSave.nowCharacter_name = CharacterSelecter.GetNowCharacter();
                    }
                }
            }
        }
        
        if (Play.text.Equals("X")){

        }
        else
        {
            SceneManager.LoadScene("main");
        }
    }
    public void MoveDarwing_Lot()
    {
        
            SaveItemList();
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
            if (Drawing_lot_Able_Character.instance.Able_Img_List.Count!=0&& CoinManager.instance.OutCoin(100))
            SceneManager.LoadScene("drawing lots");
        
        
        
    }
    private void OnApplicationQuit()
    {
        SaveItemList();
    }
   void SaveItemList()
    {
        
            List<CharacterNCoin> SaveList = new List<CharacterNCoin>();
            for (int i = 0; i < ItemList.Count; i++)
            {
                CharacterNCoin temp = new CharacterNCoin();
                temp.Create(ItemList[i].GetComponent<SpriteRenderer>().sprite.name, ItemList[i].GetComponent<Item_UnLock>().Unlcok);
                SaveList.Add(temp);
                
            }
            List<string> name = new List<string>();
            List<bool> Unlock = new List<bool>();
            for (int i = 0; i < SaveList.Count; i++)
            {
                name.Add(SaveList[i].name);
                Unlock.Add(SaveList[i].Unlock);
            }
            DataController.instance.dataSave.UnlockList_name = name;
            DataController.instance.dataSave.UnlockList_bool = Unlock;

            
        }
       
    

}
