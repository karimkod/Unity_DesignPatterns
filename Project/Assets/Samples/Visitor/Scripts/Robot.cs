using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour, IPartVisitable
{

    public IPartVisitable[] parts = new IPartVisitable[4] {new RobotBase(), new RobotLowArm(), new RobotUpperArm(), new RobotClipper()};

   public void Accept(IPartVisitor visitor)
    {
        foreach(IPartVisitable part in parts)
        {
            part.Accept(visitor);
        }
        visitor.Visit(this);
    }

}
