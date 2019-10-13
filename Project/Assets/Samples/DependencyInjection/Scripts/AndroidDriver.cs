using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidDriver : IDriver
{
   public void Control(Bike bike)
   {
       Debug.Log("Android controlling bike");
   }
}
