using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertState : IShipState
{
   public void Execute(Ship ship)
   {
       Debug.Log("On position guys, we are approaching the enemy!");
   }
}
