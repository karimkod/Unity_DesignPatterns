using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMissile : Missile
{
    // Start is called before the first frame update
    void Awake()
    {
        m_trackingStrategy = new SeekHeat();
    }

   
}
