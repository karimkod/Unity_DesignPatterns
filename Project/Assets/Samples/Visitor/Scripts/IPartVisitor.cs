using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPartVisitor
{

    void Visit(Robot visitable);
    void Visit(RobotBase robotBase); 
    void Visit(RobotLowArm robotMidArm); 
    void Visit(RobotUpperArm robotUpperArm); 
    void Visit(RobotClipper robotClipper);
}
