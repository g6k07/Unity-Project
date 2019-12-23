using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;

public class FAImpl : MonoBehaviour, IAnalyticsInterface
{
    public void Start ()
    {
            FB.Init( () => {
                FB.ActivateApp();
            });
    }
    
   public void SendEvtParamsless(string evtName) {
        Debug.Log("Send event_parametersless FaceBook Analytics");
        FB.LogAppEvent(evtName);
    }


    public void SendEvtParams(string evtName, Dictionary<string, object> parameters) {
        Debug.Log("Send event_params FaceBook Analytics");
        FB.LogAppEvent(evtName, 0, parameters);
    }

    public void SendEvtFull(string evtName, int value, Dictionary<string, object> parameters) {
        Debug.Log("Send event_full FaceBook Analytics");
        FB.LogAppEvent(evtName, value, parameters);
    }
}
