using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocatorClient : MonoBehaviour
{
   void Update()
   {
       if(Input.GetKeyDown(KeyCode.A))
       {
           ServiceLocator.Instance.GetService<LocationService>().Locate();
       }

       if(Input.GetKeyDown(KeyCode.Z))
       {
           ServiceLocator.Instance.GetService<LanguageService>().Translate();
       }

       if(Input.GetKeyDown(KeyCode.E))
       {
           ServiceLocator.Instance.GetService<CurrencyService>().Conversion();
       }
   }
}
