using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public bool OpenOption;
    public GameObject OptionBar;

    private void Start()
    {
        OptionBar = gameObject.transform.GetChild(0).gameObject;
    }
    public void OptionBarMode()
    {
        OpenOption = !OpenOption;
        if (OpenOption == true)
        {
            OptionBar.SetActive(true);
        }
        else
        {
            OptionBar.SetActive(false);
        }
    }
    public void Achievement()
    {
        GPGSBoard.instance.AchievementsUI();
    }
    public void leaderBoard()
    {
        GPGSBoard.instance.LeaderBoard();
    }
}
