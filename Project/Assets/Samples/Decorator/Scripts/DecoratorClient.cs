using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            var rifle = new BaseRifle();
            Debug.Log(rifle.GetAccuracy());
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            var rifle = new Scope(new Stabilizer(new BaseRifle()));
            Debug.Log(rifle.GetAccuracy());
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            var rifle = new Scope(new BaseRifle());
            Debug.Log(rifle.GetAccuracy());
        }
    }
}
