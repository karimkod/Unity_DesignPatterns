using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
            EventBus.Instance.Publish("Shoot");
        }

         if(Input.GetKeyDown(KeyCode.Z))
        {
            EventBus.Instance.Publish("Fire");
        }
        
    }
}
