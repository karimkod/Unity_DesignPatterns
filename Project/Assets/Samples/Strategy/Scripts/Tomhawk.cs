using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomhawk : Missile
{

    private void Awake()
    {
        m_trackingStrategy = new SeekGPS();
    }
}
