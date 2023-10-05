using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    // Start is called before the first frame update

    public bool dragging = true;
    public bool placable = false;
    public GameObject Tower;
    void Start()
    {
    }
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = MousePos;
        placeTower(); 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Grass"))
        {
            Debug.Log("GRASS");
            placable = true;

            
        }
        else if (collision.CompareTag("Path"))
        {
            Debug.Log("P A T H");
            placable = false;
        }
    }

    public void placeTower()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && placable == true)
        {
            Instantiate(Tower, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if(placable == false)
        {
            return;
        }
    }

}
   