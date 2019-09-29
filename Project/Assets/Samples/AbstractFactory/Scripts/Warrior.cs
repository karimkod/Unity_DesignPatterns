using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : IHuman
{
   public void Speak()
    {
        Debug.Log("I'll break your nose.");
    }
}
