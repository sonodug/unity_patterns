using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator
{
    public class Logger : ILoggerService
    {
        public void Log(string message)
        {
            Debug.Log("Logged: " + message);
        }
    }
}