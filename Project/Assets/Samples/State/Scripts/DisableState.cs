using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableState : IShipState
{
   public void Execute(Ship ship)
   {
       Debug.Log("Move to the rescue ship and disable the main functionalities.");
   }
}
