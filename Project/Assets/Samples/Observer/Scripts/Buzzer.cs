using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzzer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Timer.startTimeEvent += BuzzStart;
        Timer.endTimeEvent += BuzzEnd;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void BuzzStart()
    {
        Debug.Log("Buuuuuuuuuuuuuuzzzzzzz !!");
    }

    void BuzzEnd()
    {
        Debug.Log("Buz buz buz !!");

    }
}
