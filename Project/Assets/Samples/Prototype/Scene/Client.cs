using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
     public Tank tankPrototype;
     public Drone dronePrototype;
     public EnemySpawner enemySpawner;


    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            var tank  = (Tank) enemySpawner.Spawn(tankPrototype);
            tank.Run();
            
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            var drone = (Drone)enemySpawner.Spawn(dronePrototype);
            drone.Fly();
        }
    }
}
