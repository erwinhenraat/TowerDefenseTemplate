using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToWaypoint : MonoBehaviour
{
    //Maakt variable voor WaypointScript
    public WaypointScript waypointScript;
    //Wordt later gebruikt om de waypoint te zetten
    public int currentIndex;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Vind de waypoint holder in de scene
        waypointScript = GameObject.Find("WaypointHolder").GetComponent<WaypointScript>();
        speed = GetComponent<EnemyStats>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        // maakt een vector van enemy positie tot de waypoint
        Vector3 WaypointVector = waypointScript.Waypoints[currentIndex].position - transform.position;

        // als de enemy de waypoint aan raakt verandert de Index en gaat hij naar de volgende waypoint
        if(WaypointVector.magnitude <= 0.05)
        {
            currentIndex++;
        }

        //Direction 
        WaypointVector.Normalize();
        transform.position += WaypointVector * Time.deltaTime * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("LastWaypoint"))
        {
            Destroy(gameObject);
        }
        
    }
}
