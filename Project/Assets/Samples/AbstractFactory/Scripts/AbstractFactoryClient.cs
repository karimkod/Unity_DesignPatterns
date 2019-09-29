using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactoryClient : MonoBehaviour
{

    [SerializeField] private FactoryProducer factoryProducer;

    private AnimalFactory animalFactory;
    private HumanFactory humanFactory;

    // Start is called before the first frame update
    public void SpawnAnimals()
    {
        var factory = factoryProducer.GetFactory(KindType.Animal);

        factory.GetAnimal(AnimalType.Cat).Sound();
        factory.GetAnimal(AnimalType.Dog).Sound();
        factory.GetAnimal(AnimalType.Horse).Sound();

    }

    public void SpawnHumans()
    {
        var factory = factoryProducer.GetFactory(KindType.Human);

        factory.GetHuman(HumanType.Warrior).Speak();
        factory.GetHuman(HumanType.Fighter).Speak();
        factory.GetHuman(HumanType.Chevalier).Speak();

    }
    void Start()
    {
        SpawnAnimals();
        SpawnHumans();
    }
}
