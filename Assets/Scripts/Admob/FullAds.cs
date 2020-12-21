using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullAds : MonoBehaviour
{
    public static FullAds instance;
   
    private string realAd = "ca-app-pub-3940256099942544/1033173712";
    private string testAd = "ca-app-pub-3940256099942544/1033173712";
    public InterstitialAd screenAd;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
       
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
        Debug.Log("실행");
        InitAd();
        StartCoroutine("ShowScreenAd");
        InitAd();
    }
    public IEnumerator ShowScreenAd()
    {
        while (!screenAd.IsLoaded())
        {
            Debug.Log("로딩");
            yield return null;
        }
        Debug.Log("완료");
        screenAd.Show();
    }
}
