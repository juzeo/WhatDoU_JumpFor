using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopBtn : MonoBehaviour
{
    public GameObject CharacterScroll;
    public GameObject CoinScroll;
    public Image CoinBtnImg;
    public Image CharacterBtnImg;

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
}
