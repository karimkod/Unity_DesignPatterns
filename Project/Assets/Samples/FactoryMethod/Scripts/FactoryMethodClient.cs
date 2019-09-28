using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethodClient : MonoBehaviour
{

    public NPCFactory npcFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            npcFactory.Spawner(NPCTypes.Farmer).Speak();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            npcFactory.Spawner(NPCTypes.Shopowner).Speak();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            npcFactory.Spawner(NPCTypes.Villager).Speak();
        }
    }
}
