using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : Command
{


    public TurnOn(IReceiver receiver) : base(receiver)
    {
        
    }

    public override void Execute()
    {
        receiver.TurnOn();
    }
}
