using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class UAImpl : MonoBehaviour, IAnalyticsInterface
{
    public void SendEvtParamsless(string evtName) {
        Debug.Log("Send event_parametersless Unity Analytics");
        Analytics.CustomEvent(evtName);
    }

    public void SendEvtParams(string evtName, Dictionary<string, object> parameters) {
        Debug.Log("Send event_params Unity Analytics");
        Analytics.CustomEvent(evtName, parameters);
    }

    public void SendEvtFull(string evtName, int value, Dictionary<string, object> parameters) {
        Debug.Log("Send event_full Unity Analytics");
        Dictionary<string, object> parametersCopy = new Dictionary<string, object>(parameters);
        parametersCopy.Add("valeur", value);
        Analytics.CustomEvent(evtName, parametersCopy);
    }
}
