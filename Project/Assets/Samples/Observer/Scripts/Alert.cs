using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Timer.halfTimeEvent += AlertHalfTime;
    }

    // Update is called once per frame
    void AlertHalfTime()
    {
        Debug.Log("Haaalf time !!");
    }
}
