using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdapterClient : MonoBehaviour
{
    IClassAdapter adapter; 

    void Start()
    {
        adapter = new CAOnlinePlayerAdapter(); 


        Debug.Log("First name " + adapter.GetFirstName(0));
        Debug.Log("Last name " + adapter.GetLastName(0));

        Debug.Log("Full name last first name format " + adapter.GetFullNameLastFirst(0));

        Debug.Log("Fune name first last name format  " + adapter.GetFullNameFirstLast(0));


    }




}
