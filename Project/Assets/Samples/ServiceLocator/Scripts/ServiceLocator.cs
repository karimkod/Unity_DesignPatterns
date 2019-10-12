using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ServiceLocator : Singleton<ServiceLocator>
{

    public Dictionary<object, object> register; 

    override public void Awake()
    {
        base.Awake();
        Init();
    }

    private void Init()
    {
        register = new Dictionary<object, object>();
        register.Add(typeof(CurrencyService), new CurrencyService());
        register.Add(typeof(LocationService), new LocationService());
        register.Add(typeof(LanguageService), new LanguageService());

    }


    private T GetService<T>()
    {
        try 
        {
            return (T) register[typeof(T)];
        }catch
        {
            throw new ApplicationException("Service not registred.");
        }
    }



}
