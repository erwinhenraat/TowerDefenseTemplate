using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private Path path;
    [SerializeField] private float speed = 5;
    [SerializeField] private int nextWaypointIndex = 1;
    [SerializeField] private float reachedWaypointClearance = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = path.waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, path.waypoints[nextWaypointIndex].position, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, path.waypoints[nextWaypointIndex].position) <= reachedWaypointClearance) 
        {
            nextWaypointIndex++;
        }

        if (nextWaypointIndex >= path.waypoints.Length) 
        { 
            nextWaypointIndex = 0;
        }
    }
    private void Awake()
    {
        path = FindAnyObjectByType<Path>();
    }
}
