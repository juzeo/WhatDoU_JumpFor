using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerAds : MonoBehaviour
{

    public static BannerAds instance;
    private string realAd = "ca-app-pub-3940256099942544/6300978111";
    private string testAd = "ca-app-pub-3940256099942544/6300978111";
    public BannerView bannerview;

   public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        MobileAds.Initialize(

            (initStatus) => InitAd()
            

            );
        bannerview.Show();
    }
    public void InitAd()
    {
        bannerview = new BannerView(realAd, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerview.LoadAd(request);
  
        showBanner();
    }
    public void showBanner()
    {
        try
        {
            bannerview.Show();
          
        }
        catch
        {
          
        }

    }
    public void hideBanner()
    {
        try{
            bannerview.Hide();
         
        }
        catch
        {
          
        }
        

        
    }
}