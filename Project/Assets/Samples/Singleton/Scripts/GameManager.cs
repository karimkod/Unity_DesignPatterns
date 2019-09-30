using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
   public void InitGame()
    {
        Debug.Log("Game have been initialized.");
    }
}
