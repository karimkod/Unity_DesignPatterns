using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlinePlayerAdapter
{
   public string GetFirstNameLastName(OAOnlinePlayer onlinePlayer, int id)
   {

       return onlinePlayer.GetFirstName(id) + " " + onlinePlayer.GetLastName(id);
    }
}
