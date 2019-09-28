using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
   public INPC Spawner(NPCTypes types)
    {
        switch(types)
        {
            case NPCTypes.Farmer:
                return new Farmer();
            case NPCTypes.Shopowner:
                return new ShopOwner();
            case NPCTypes.Villager:
                return new Villager();
        }
        return null;
    }
}
