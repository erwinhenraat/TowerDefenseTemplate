using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //make an array for the enemies
    public GameObject enemyA, enemyB, enemyC;
    public GameObject[] enemies;
    public float delay;
    public float timeBetweenDelay = 3;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenDelay -= Time.deltaTime; //checks how much time passed
        if (timeBetweenDelay <= 0) // checks if timer is up
        {
            timeBetweenDelay = 3; // resets timer
            StartCoroutine(SpawnDelay(enemyA)); // starts spawn 
            
        }
    }
    private IEnumerator SpawnWholeArray(GameObject[] enemies)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
         // delay is space/time between enemy spawns
            yield return new WaitForSeconds(delay); // wait for [delay] seconds
            Instantiate(enemies[i], transform.position, Quaternion.identity); // spawn enemy
        }
    }
    private IEnumerator SpawnDelay(GameObject enemy)
    {
        yield return new WaitForSeconds(delay); // wait for [delay] seconds
        Instantiate(enemy, transform.position, Quaternion.identity); // spawn enemy
    }
}
