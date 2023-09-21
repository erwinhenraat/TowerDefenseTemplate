using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner main;
    
    
    public Transform StartPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this; 
    }

}
