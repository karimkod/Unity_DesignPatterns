using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBase : IPartVisitable
{
    public void Accept(IPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}
