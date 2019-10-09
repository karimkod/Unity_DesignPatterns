using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RifleDecorator : IRifle
{ 
    protected IRifle decoratedRifle; 

    public RifleDecorator(IRifle rifle)
    {
        this.decoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return decoratedRifle.GetAccuracy();
    }
}
