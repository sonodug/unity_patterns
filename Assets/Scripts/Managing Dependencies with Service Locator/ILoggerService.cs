using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator
{
    public interface ILoggerService
    {
        void Log(string message);
    }
}