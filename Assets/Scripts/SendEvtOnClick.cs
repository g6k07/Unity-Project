using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using GameAnalyticsSDK;


public class SendEvtOnClick : MonoBehaviour
{
    List<IAnalyticsInterface> analyticsServices = new List<IAnalyticsInterface> ();

    public void Start() {
 
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("srv_analytics"))
        {
            Debug.Log("---analyticsServices = "+ gameObject.name);

            analyticsServices.Add(gameObject.GetComponent<IAnalyticsInterface>());
        }
    }
    
   public void SendEvt(int index) {
       switch(index)
       {
           case 0:
                string eventName0 = "Event_paramsless";

                foreach (IAnalyticsInterface aInterface in analyticsServices)
                {
                    Debug.Log("Send event "+ eventName0 +" to interface : "+ aInterface);
                    aInterface.SendEvtParamsless(eventName0);
                }
                break;
                
            case 1:
                string eventName1 = "Event_params";
                Dictionary<string, object> eventData1 = new Dictionary<string, object> ();
                eventData1.Add("valeur", 42);

                foreach (IAnalyticsInterface aInterface in analyticsServices)
                {
                    Debug.Log("Send event "+ eventName1 +" to interface : "+ aInterface);
                    aInterface.SendEvtParams(eventName1, eventData1);
                }
                break;

            case 2:
                string eventName2 = "Event_full";
                int value = 12;
                Dictionary<string, object> eventData2 = new Dictionary<string, object> ();
                eventData2.Add("nom", "toto");

                foreach (IAnalyticsInterface aInterface in analyticsServices)
                {
                    Debug.Log("Send event "+ eventName2 +" to interface : "+ aInterface);
                    aInterface.SendEvtFull(eventName2, value, eventData2);
                }
                break;
            
            default:
                break;
       }
   }
}
