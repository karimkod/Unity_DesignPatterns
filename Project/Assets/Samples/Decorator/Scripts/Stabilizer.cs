using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilizer : RifleDecorator
{

    private float accuracyBoost = 25; 
   public Stabilizer(IRifle rifle):base(rifle)
   {
   }

   public override float GetAccuracy()
   {
       return decoratedRifle.GetAccuracy() + accuracyBoost;
   }


}
