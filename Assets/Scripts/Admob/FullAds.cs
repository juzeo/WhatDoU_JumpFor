using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullAds : MonoBehaviour
{
    public static FullAds instance;
   
    private string realAd = "ca-app-pub-3940256099942544/86916914335";
    private string testAd = "ca-app-pub-3940256099942544/8691691433";
    public InterstitialAd screenAd;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        MobileAds.Initialize(

             (initStatus) => InitAd()

             );
    }
  

    public void InitAd()
    {

        screenAd = new InterstitialAd(realAd);
        AdRequest request = new AdRequest.Builder().Build();
        screenAd.LoadAd(request);

    }
    public void show()
    {
        
        StartCoroutine("ShowScreenAd");
        InitAd();
    }
    public IEnumerator ShowScreenAd()
    {
        while (!screenAd.IsLoaded())
        {
           
            yield return null;
        }

        screenAd.Show();
    }
}
