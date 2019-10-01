using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Missile : ScriptableObject
{

    protected TrackingStrategy m_trackingStrategy; 

    public void ApplySeek()
    {
        m_trackingStrategy.Seek();
    }

    public void SetSeekStrategy(TrackingStrategy trackingStrategy)
    {
        m_trackingStrategy = trackingStrategy;
    }
}
