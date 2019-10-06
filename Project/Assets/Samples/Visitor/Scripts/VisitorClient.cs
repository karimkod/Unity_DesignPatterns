using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorClient : MonoBehaviour
{
   [SerializeField] private Robot robot; 


   void Update()
   {
       if(Input.GetKeyDown(KeyCode.A))
       {
           TurnOn();
       }

       if(Input.GetKeyDown(KeyCode.Z))
       {
           TurnOff();
       }
   }

   private void TurnOn()
   {
       var turnOn = new TurnOnVisitor();

       robot.Accept(turnOn);
   }    

    private void TurnOff()
   {
       var turnOff = new TurnOffVisitor();

       robot.Accept(turnOff);
   }       
}
