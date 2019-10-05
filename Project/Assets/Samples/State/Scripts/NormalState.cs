using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalState : IShipState
{
   public void Execute(Ship ship)
   {
       Debug.Log("Everything is alrigh");
   }
}
