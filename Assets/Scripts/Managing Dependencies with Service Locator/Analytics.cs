using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator
{
    public class Analytics : IAnalyticsService
    {
        public void SendEvent(string eventName)
        {
            Debug.Log("Sent: " + eventName);
        }
    }
}