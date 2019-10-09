using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRifle : IRifle
{
    private float accuracy = 20; 

    public float GetAccuracy()
    {
        return accuracy;
    }
        
    
}
