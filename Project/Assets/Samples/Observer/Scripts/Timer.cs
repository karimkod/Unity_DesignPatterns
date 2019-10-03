using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   [SerializeField] private float time; 
   private float halfTime; 

   public delegate  void StartTime();
   public static event StartTime startTimeEvent;  

    public delegate  void HalfTime();
   public static event HalfTime halfTimeEvent;  

    public delegate  void EndTime();
   public static event EndTime endTimeEvent;


    IEnumerator Start()
    {

        halfTime = time/2;
        if(startTimeEvent != null)
        {
            startTimeEvent();
        }

        yield return StartCoroutine(TimeAndPrint());


        if(endTimeEvent != null)
        {
            endTimeEvent();
        }
    }


    private IEnumerator TimeAndPrint()
    {
        while(Time.time < time)
        {
            yield return new WaitForSeconds(1.0f);

            Debug.Log("Time is at " + Time.time);

            if(Mathf.Round(Time.time) == Mathf.Round(halfTime))
            {
                if(halfTimeEvent != null)
                {
                    halfTimeEvent();
                }
            }
        }
    }



}
