using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependencyInjectionClient : MonoBehaviour
{


    [SerializeField] private Bike androidBike; 
    [SerializeField] private Bike humanBike; 



    // Start is called before the first frame update
    void Start()
    {
        androidBike.SetDriver(new AndroidDriver()); 
        androidBike.SetEngine(new JetEngine());
        androidBike.StartCar();

        humanBike.SetDriver(new HumanDriver()); 
        humanBike.SetEngine(new TurboEngine());
        humanBike.StartCar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
