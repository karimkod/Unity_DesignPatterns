using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Instance.Subscribe("Fire", Fire);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        Debug.Log("Pew pew pew pew.");
    }
}
