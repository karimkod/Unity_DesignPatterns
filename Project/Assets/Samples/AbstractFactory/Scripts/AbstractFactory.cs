using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactor
{
    public abstract IHuman GetHuman(HumanType humanType);
    public abstract IAnimal GetAnimal(AnimalType animalType);
}
