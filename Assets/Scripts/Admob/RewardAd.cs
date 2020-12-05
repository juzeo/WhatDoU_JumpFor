using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardAd : MonoBehaviour
{
    public static RewardAd instance;
   
    private string realAd = "ca-app-pub-3940256099942544/5224354917";
    private string testAd = "ca-app-pub-3940256099942544/5224354917";

    private RewardedAd rewardAd;

    public void Awake()
    {
        instance = this;
        rewardAd = new RewardedAd(realAd);
        Handle(rewardAd);
        Load();
    }

    private void Handle(RewardedAd videoAd)
    {
        videoAd.OnAdLoaded += HandleOnAdLoaded;
        videoAd.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        videoAd.OnAdFailedToShow += HandleOnAdFailedToShow;
        videoAd.OnAdOpening += HandleOnAdOpening;
        videoAd.OnAdClosed += HandleOnAdClosed;
        videoAd.OnUserEarnedReward += HandleOnUserEarnedReward;
    }

    private void Load()
    {
        AdRequest request = new AdRequest.Builder().Build();
        rewardAd.LoadAd(request);
    }

    public RewardedAd ReloadAd()
    {
        RewardedAd videoAd = new RewardedAd(realAd);
        Handle(videoAd);
        AdRequest request = new AdRequest.Builder().Build();
        videoAd.LoadAd(request);
        return videoAd;
    }

    public void Show()
    {
        StartCoroutine("ShowRewardAd");
    }

    private IEnumerator ShowRewardAd()
    {
        while (!rewardAd.IsLoaded())
        {
            yield return null;
        }
        rewardAd.Show();
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {

    }

    public void HandleOnAdFailedToLoad(object sender, AdErrorEventArgs args)
    {

    }

    public void HandleOnAdFailedToShow(object sender, AdErrorEventArgs args)
    {

    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {

    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
     
    }

    public void HandleOnUserEarnedReward(object sender, EventArgs args)
    {

       
        
    }
}