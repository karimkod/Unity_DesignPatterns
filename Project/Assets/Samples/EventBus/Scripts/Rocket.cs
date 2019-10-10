using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Instance.Subscribe("Shoot", Shoot);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Debug.Log("Boookh boookh bookh.");
    }
}
