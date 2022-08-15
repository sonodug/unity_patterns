using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public interface IWeapon
    {
        public float Rate { get; }
        public float Range { get; }
        public float Strength { get; }
        public float Cooldown { get; }
    }
}