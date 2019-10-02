using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Television : IReceiver
{
   public void TurnOn()
   {
       Debug.Log("TV Turned on");
   }

   public void TurnOff()
   {
       Debug.Log("TV Turned off");

   }
}
