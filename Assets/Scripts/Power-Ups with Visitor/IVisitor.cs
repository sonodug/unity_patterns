using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public interface IVisitor
    {
        void Visit(BikeShield bikeShield);
        void Visit(BikeEngine bikeEngine);
        void Visit(BikeWeapon bikeWeapon);
    }
}
