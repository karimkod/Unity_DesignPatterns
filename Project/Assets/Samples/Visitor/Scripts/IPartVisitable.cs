using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPartVisitable
{
    void Accept(IPartVisitor visitor);
}
