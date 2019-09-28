using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy Spawn(Enemy copyable)
    {
        return (Enemy)copyable.Copy();  
    }
}
