using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour
{
    public Transform[] Waypoints;


    // Start is called before the first frame update
    void Start()
    {
        // Lengte van waypoints is lengte van WaypointHolder (gameobject)
        Waypoints = new Transform[transform.childCount];

        // zet elke child in de array
        for (int i = 0; i < transform.childCount; i++)
        {
            Waypoints[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
