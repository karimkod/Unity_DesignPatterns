using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAdapterClient : MonoBehaviour
{
    OAOnlinePlayer onlinePlayer; 
    OnlinePlayerAdapter onlinePlayerAdapter; 


    void Start()
    {
        onlinePlayer = new OAOnlinePlayer(); 
        onlinePlayerAdapter = new OnlinePlayerAdapter(); 


        Debug.Log("First name " + onlinePlayer.GetFirstName(0));
        Debug.Log("Last name " + onlinePlayer.GetLastName(0));

        Debug.Log("Full name last first name format " + onlinePlayer.GetFullName(0));

        Debug.Log("Fune name first last name format " + onlinePlayerAdapter.GetFirstNameLastName(onlinePlayer, 0));


    }



}
