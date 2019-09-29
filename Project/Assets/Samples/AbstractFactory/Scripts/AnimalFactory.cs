using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFactory : AbstractFactor
{
    public override IHuman GetHuman(HumanType humanType)
    {
       
        return null;
    }

    public override IAnimal GetAnimal(AnimalType animalType)
    {
        switch (animalType)
        {
            case AnimalType.Cat:
                return new Cat();
            case AnimalType.Dog:
                return new Dog();
            case AnimalType.Horse:
                return new Horse();

        }
        return null;
    }

}
