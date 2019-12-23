using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;
using System; 

public class GAImpl : MonoBehaviour, IAnalyticsInterface
{
    public void Start() {
        GameAnalytics.Initialize();
    }

    public void SendEvtParamsless(string evtName) {
        Debug.Log("Send event_parametersless Game Analytics");
        GameAnalytics.NewDesignEvent(evtName);
    }


    public void SendEvtParams(string evtName, Dictionary<string, object> parameters) {
        Debug.Log("Send event_params Game Analytics");
        string evtCpy = String.Copy(evtName);
        foreach (var item in parameters)
        {
            evtCpy += ":" + item.Key + ":" + item.Value;      
        }
        GameAnalytics.NewDesignEvent(evtCpy);
    }

    public void SendEvtFull(string evtName, int value, Dictionary<string, object> parameters) {
        Debug.Log("Send event_full Game Analytics");
        string evtCpy = String.Copy(evtName);
        foreach (var item in parameters)
        {
            evtCpy += ":" + item.Key +":"+ item.Value;      
        }
        GameAnalytics.NewDesignEvent (evtCpy, value);
    }
}
