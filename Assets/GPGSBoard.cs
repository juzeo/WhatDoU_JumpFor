using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class GPGSBoard : MonoBehaviour
{
    public static GPGSBoard instance;

    public void Awake()
    {

        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }

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
   
            Social.Active.ShowLeaderboardUI();
      
        Debug.Log("LeaderBoard");
    
    }
    public void AchievementsUI()
    {
        if (Social.localUser.authenticated == false)
        {
            Awake();
        }
       
        Social.Active.ShowAchievementsUI();
      
        Debug.Log("achievement");
       
    }
   
    public void topLeaderboard(int score)
    {
        if (Social.localUser.authenticated == true)
        {
            Social.ReportScore(score, "CgkIkquU2r8GEAIQBA", (bool success) =>
            {

            });
        }
    }
    public void Dieachievement()
    {
        if (Social.localUser.authenticated == true)
        {
            Social.ReportProgress(
      "CgkIkquU2r8GEAIQBQ", 100, (bool success) =>
      {
          // handle success or failure
      });
        }
    }

}