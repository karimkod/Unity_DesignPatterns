using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanFactory : AbstractFactor
{
    public override IHuman GetHuman(HumanType humanType)
    {
        switch(humanType)
        {
            case HumanType.Chevalier:
                return new Chevalier();
            case HumanType.Fighter:
                return new Fighter();
            case HumanType.Warrior:
                return new Warrior();
        }
        return null;
    }

    public override IAnimal GetAnimal(AnimalType animalType)
    {
        return null;
    }

}
