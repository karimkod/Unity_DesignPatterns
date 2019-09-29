using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : IHuman
{
    public void Speak()
    {
        Debug.Log("I can fight everywhere you want me to fight.");
    }
}
