using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffVisitor : IPartVisitor
{
      public void Visit(Robot robot)
   {
       Debug.Log("Robot Turned Off!");
   }

    public void Visit(RobotBase robot)
   {
              Debug.Log("RobotBase Turned Off!");

   }

    public void Visit(RobotLowArm robot)
   {
              Debug.Log("RobotLowArm Turned Off!");

   }

    public void Visit(RobotUpperArm robot)
   {
              Debug.Log("RobotUpperArm Turned Off!");

   }

    public void Visit(RobotClipper robot)
   {
              Debug.Log("RobotClipper Turned Off!");

   }
}
