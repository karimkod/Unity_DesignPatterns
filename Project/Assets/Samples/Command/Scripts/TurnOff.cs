using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : Command
{
    public TurnOff(IReceiver receiver):base(receiver)
    {

    }

    public override void Execute()
    {
        receiver.TurnOff();
    }
}
