using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : Command
{
    
    private IReceiver[] receivers;
     private static IReceiver receiver;
    
    public Kill(IReceiver[] receivers):base(receiver)
    {
        this.receivers = receivers;
    }

    public override void Execute()
    {
        foreach(IReceiver r in receivers)
        {
            r.TurnOff();
        }
    }



}

