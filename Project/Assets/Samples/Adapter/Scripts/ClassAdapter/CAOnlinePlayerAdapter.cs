using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAOnlinePlayerAdapter : CAOnlinePlayer, IClassAdapter
{
    public string GetFullNameLastFirst(int id)
    {
        return GetFullName(id);
    }

    public string GetFullNameFirstLast(int id)
    {
        return (GetFirstName(id) + " " + GetLastName(id));
    }
}
