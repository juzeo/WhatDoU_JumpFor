using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class GPGSBoard : MonoBehaviour
{
    /*
    public void Awake()
    {
 
        PlayGamesPlatform.InitializeInstance(new PlayGamesClientConfiguration.Builder().Build());
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool Success) => { });
    }
    public void LeaderBoard()
    {
        if (Social.localUser.authenticated == false)
        {
            Awake();
        }
        Debug.Log("LeaderBoard");
        Social.Active.ShowLeaderboardUI();
    }
    public void AchievementsUI()
    {
        if (Social.localUser.authenticated == false)
        {
            Awake();
        }
        Debug.Log("achievement");
        Social.ShowAchievementsUI();
    }
   
    public void testLeaderboard(int score)
    {
        if (Social.localUser.authenticated == true)
        {
            Social.ReportScore(score, "CgkIkquU2r8GEAIQAw", (bool success) =>
            {

            });
        }
    }
    public void achievement()
    {
        if (Social.localUser.authenticated == true)
        {
            PlayGamesPlatform.Instance.IncrementAchievement(
      "CgkIkquU2r8GEAIQAg", 100, (bool success) =>
      {
          // handle success or failure
      });
        }
    }*/

}