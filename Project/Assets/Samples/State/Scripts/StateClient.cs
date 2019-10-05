using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateClient : MonoBehaviour
{


    [SerializeField] private Ship ship;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ship.NormalizeShip();
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            ship.AlertShip();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            ship.DisableShip();
        }

        
    }
}
