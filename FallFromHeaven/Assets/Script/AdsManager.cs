using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class AdsManager : MonoBehaviour , IUnityAdsListener
{
    string gameId = "3915347";
    bool testMode = true;
    string myPlacementId = "rewardedVideo";



    private void Start()
    {

        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);

    }

    public void ShowInterstitialAd()
    {
        if(Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show();
        }
        else
        {


        }
    }

    public void ShowRewarededVideo()
    {
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
        }
        else
        {
           
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        if(placementId == myPlacementId)
        {
            //광고보고 보상받기
        }
    }

    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidStart(string placementId)
    {
 
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(placementId == myPlacementId)
        {
            if(showResult == ShowResult.Finished)
            {
                Debug.Log("hungry");
            }
        }
    }
}
