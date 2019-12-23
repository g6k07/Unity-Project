using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IAnalyticsInterface
{
    void SendEvtParamsless(string evtName);
    void SendEvtParams(string evtName, Dictionary<string, object> parameters);
    void SendEvtFull(string evtName,int value, Dictionary<string, object> parameters);
}


