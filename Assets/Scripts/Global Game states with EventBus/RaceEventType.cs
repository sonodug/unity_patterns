using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventBus
{
    public enum RaceEventType
    {
        COUNTDOWN,
        START,
        PAUSE,
        STOP,
        FINISH,
        RESTART,
        QUIT
    }
}