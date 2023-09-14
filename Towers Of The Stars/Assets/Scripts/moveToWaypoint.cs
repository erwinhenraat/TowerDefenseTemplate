using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToWaypoint : MonoBehaviour
{
    //Maakt variable voor WaypointScript
    public WaypointScript waypointScript;
    //Wordt later gebruikt om de waypoint te zetten
    public int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
        // Vind de waypoint holder in de scene
        waypointScript = GameObject.Find("WaypointHolder").GetComponent<WaypointScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // maakt een vector van enemy positie tot de waypoint
        Vector3 WaypointVector = waypointScript.Waypoints[currentIndex].position - transform.position;

        // als de enemy de waypoint aan raakt verandert de Index en gaat hij naar de volgende waypoint
        if(WaypointVector.magnitude <= 0.001)
        {
            currentIndex++;
        }

        //Direction 
        WaypointVector.Normalize();
        transform.position += WaypointVector * Time.deltaTime;
    }
}
