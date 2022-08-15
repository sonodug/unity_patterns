using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator
{
    public interface IAnalyticsService
    {
        void SendEvent(string eventName);
    }
}