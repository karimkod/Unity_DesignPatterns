using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : IReceiver
{
   public void TurnOn()
   {
       Debug.Log("Radio Turned on");
   }

   public void TurnOff()
   {
       Debug.Log("Radio Turned off");

   }
}
