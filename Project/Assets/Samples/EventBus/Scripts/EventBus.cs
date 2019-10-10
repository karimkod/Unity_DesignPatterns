using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventBus : Singleton<EventBus>
{
    private Dictionary<string, UnityEvent> events; 


    override public void Awake()
    {
        base.Awake(); 
        Init();
    }

    private void Init()
    {
        events = new Dictionary<string, UnityEvent>();
    }

    public void Subscribe (string eventName, UnityAction action)
    {
        UnityEvent requestEvent = null;

        events.TryGetValue(eventName, out requestEvent); 

        if(requestEvent != null)
        {
            requestEvent.AddListener(action); 
        }else 
        {
            events[eventName] = new UnityEvent();
            events[eventName].AddListener(action);
        }

    }

   public void Unsubscribe (string eventName, UnityAction action)
    {
        UnityEvent requestEvent = null;

        events.TryGetValue(eventName, out requestEvent); 

        if(requestEvent != null)
        {
            requestEvent.RemoveListener(action); 
        }

    }

    public void Publish(string eventName)
    {
        UnityEvent requestEvent = null;

        events.TryGetValue(eventName, out requestEvent); 

        if(requestEvent != null)
        {
            requestEvent.Invoke(); 
        }
    }

}