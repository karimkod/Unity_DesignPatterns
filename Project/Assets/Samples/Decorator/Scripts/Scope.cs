using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : RifleDecorator
{
    private float accuracyBoost = 10f; 

    public Scope(IRifle rifle) : base(rifle){}

    public override float GetAccuracy()
    {
        return decoratedRifle.GetAccuracy() + accuracyBoost;
    }

}
