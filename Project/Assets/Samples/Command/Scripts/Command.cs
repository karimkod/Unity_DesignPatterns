using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{

    protected IReceiver receiver; 
   public Command(IReceiver receiver)
   {
       this.receiver = receiver;
   }

   public abstract void Execute();
}
