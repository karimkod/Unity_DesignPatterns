using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    IShipState state; 

    void Awake()
    {
        state = new NormalState(); 
        state.Execute(this);
    }

    public void NormalizeShip()
    {
        state = new NormalState(); 
        state.Execute(this);
    }
    
    public void AlertShip()
    {
        state = new AlertState(); 
        state.Execute(this);
    }
    

    public void DisableShip()
    {
        state = new DisableState(); 
        state.Execute(this);
    }
    


}
