using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnVisitor : IPartVisitor
{
   public void Visit(Robot robot)
   {
       Debug.Log("Robot Turned On!");
   }

    public void Visit(RobotBase robot)
   {
              Debug.Log("RobotBase Turned On!");

   }

    public void Visit(RobotLowArm robot)
   {
              Debug.Log("RobotLowArm Turned On!");

   }

    public void Visit(RobotUpperArm robot)
   {
              Debug.Log("RobotUpperArm Turned On!");

   }

    public void Visit(RobotClipper robot)
   {
              Debug.Log("RobotClipper Turned On!");

   }
}
