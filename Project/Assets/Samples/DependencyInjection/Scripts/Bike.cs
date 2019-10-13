using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
  
    private IDriver driver; 
    private IEngine engine; 

    public void SetDriver(IDriver driver)
    {
        this.driver = driver;
    }

    public void SetEngine(IEngine engine)
    {
        this.engine = engine;
    }


    public void StartCar()
    {
        engine.Start(); 
        driver.Control(this);
    }

    public void TurnRight()
    {
        Debug.Log("Turning right");
    }

    public void TurnLeft()
    {
        Debug.Log("Turning Left");
    }
}
