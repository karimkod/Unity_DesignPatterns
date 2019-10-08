using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClassAdapter
{
      string GetFirstName(int id);

    string GetLastName(int id);


    string GetFullNameLastFirst(int id);
 

     string GetFullNameFirstLast(int id);
}
