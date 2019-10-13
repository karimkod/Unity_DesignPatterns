using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDriver : IDriver
{
   public void Control(Bike bike)
   {
       Debug.Log("Human controlling bike");
   }
}
