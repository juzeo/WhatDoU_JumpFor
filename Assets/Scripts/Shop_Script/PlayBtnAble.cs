using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBtnAble : MonoBehaviour
{
    Scroll scroll;
    public List<bool> ScrollItem_Unlock;
    public GameObject PlayBtn;
    // Start is called before the first frame update
    void Awake()
    {
        ScrollItem_Unlock = new List<bool>();
        scroll = gameObject.GetComponent<Scroll>();
        for (int i = 0; i < scroll.ScrollItem.Count; i++)
        {
         
            if (scroll.ScrollItem[i].GetComponent<SpriteRenderer>().sprite == Drawing_lot_Able_Character.instance.GetCharacter)
            {
                scroll.ScrollItem[i].GetComponent<Item_UnLock>().Unlcok = true;
                Debug.Log(Drawing_lot_Able_Character.instance.GetCharacter.name+"해금");
            }
                
            ScrollItem_Unlock.Add(scroll.ScrollItem[i].GetComponent<Item_UnLock>().Unlcok);
            if (ScrollItem_Unlock[i] == false)
            {
                scroll.ScrollItem[i].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }

    public void BtnChange(int num)
    {
       
        if (ScrollItem_Unlock[num] == true)
        {
            PlayBtn.GetComponent<Text>().text = "Play";
            
        }
        else
        {
            PlayBtn.GetComponent<Text>().text = "X";
        }
        
    }
}
