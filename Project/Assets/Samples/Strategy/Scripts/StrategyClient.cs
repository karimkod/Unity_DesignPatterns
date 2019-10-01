using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            var tomhowk = ScriptableObject.CreateInstance<Tomhawk>();
            tomhowk.ApplySeek();

            var waterMissile = ScriptableObject.CreateInstance<SharkMissile>();
            tomhowk.ApplySeek();

            var airMissile = ScriptableObject.CreateInstance<EagleMissile>();
            tomhowk.ApplySeek();

        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            var tomhowkMutant = ScriptableObject.CreateInstance<Tomhawk>();
            tomhowkMutant.SetSeekStrategy(new SeekSound());
            tomhowkMutant.ApplySeek();

        }
    }
}
