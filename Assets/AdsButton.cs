using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System;

[RequireComponent (typeof (Button))]
public class AdsButton : MonoBehaviour, IUnityAdsListener {

    private string gameId = "3406085";

    Button myButton;
    RawImage myIndicator;
    public string myPlacementId;

    void Start () {   
        myButton = GetComponent <Button> ();

        if (String.Equals(myButton.name, "Button_display_rewarded"))
        {
            myPlacementId = "rewardedVideo";
        }
        else if (String.Equals(myButton.name, "Button_display_interstitial"))
        {
            myPlacementId = "interstitialVideo";
        }

        myIndicator = GetComponentInChildren <RawImage> ();

        if (myButton) myButton.onClick.AddListener (ShowVideo);

        // Initialize the Ads listener and service:
        Advertisement.AddListener (this);
        Advertisement.Initialize (gameId, true);
    }

    // Implement a function for showing a rewarded video ad:
    void ShowVideo () {
        Advertisement.Show (myPlacementId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsReady (string placementId) {
        if (placementId == myPlacementId) {        
            myIndicator.color = new Color32(0,255,0,100);
        }
    }

    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            // Reward the user for watching the ad to completion.
        } else if (showResult == ShowResult.Skipped) {
            // Do not reward the user for skipping the ad.
        } else if (showResult == ShowResult.Failed) {
            Debug.Log ("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string placementId) {
        // Optional actions to take when the end-users triggers an ad.
    } 
}