using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chevalier : IHuman
{
   public void Speak()
    {
        Debug.Log("You can't defeat me peasant!");
    }
}
