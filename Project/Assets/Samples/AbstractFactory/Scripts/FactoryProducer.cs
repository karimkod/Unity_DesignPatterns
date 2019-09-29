using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryProducer : MonoBehaviour
{
   public AbstractFactor GetFactory(KindType kindType)
    {
        switch(kindType)
        {
            case KindType.Human:
                return new HumanFactory();
            case KindType.Animal:
                return new AnimalFactory(); 
        }
        return null;
    }
}
