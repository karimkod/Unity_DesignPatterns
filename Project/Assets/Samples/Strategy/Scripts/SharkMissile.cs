using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMissile : Missile
{
    private void Awake()
    {
        m_trackingStrategy = new SeekSound();
    }
}
