using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandClient : MonoBehaviour
{


    private IReceiver TV; 
    private IReceiver Radio; 
    private IReceiver[] AllReceivers = new IReceiver[2];

    private Invoker invoker;

    // Start is called before the first frame update
    void Start()
    {
        TV = new Television();
        Radio = new Radio();

        AllReceivers[0] = TV; 
        AllReceivers[1] = Radio;

        invoker = new Invoker();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            var TurnTV = new TurnOn(TV); 
            invoker.SetCommand(TurnTV); 
            invoker.ExecuteCommand();


            var TurnRadio = new TurnOn(Radio); 
            invoker.SetCommand(TurnRadio); 
            invoker.ExecuteCommand();

        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            var TurnTV = new TurnOff(TV); 
            invoker.SetCommand(TurnTV); 
            invoker.ExecuteCommand();


            var TurnRadio = new TurnOff(Radio); 
            invoker.SetCommand(TurnRadio); 
            invoker.ExecuteCommand();

        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            var TurnOffAll = new Kill(AllReceivers);
            invoker.SetCommand(TurnOffAll); 
            invoker.ExecuteCommand();

        }
    }
}
