using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator
{
    public static class ServiceLocator
    {
        private static readonly IDictionary<Type, object> Services = new Dictionary<Type, System.Object>();

        public static void RegisterService<T>(T service)
        {
            if (!Services.ContainsKey(typeof(T)))
            {
                Services[typeof(T)] = service;
            }
            else
            {
                throw new ApplicationException("Service already registered");
            }
        }

        public static T GetService<T>()
        {
            try
            {
                return (T)Services[typeof(T)];
            }
            catch
            {
                throw new ApplicationException("Requested service not found.");
            }
        }
    }
}