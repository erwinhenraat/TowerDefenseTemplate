using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.VFX;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    [System.Serializable]

    public class Wave
    {

        public string name;

        public Enemy[] enemies;


    }
    [System.Serializable]

    public class Enemy
    {
        public Transform enemyTransform;

        public int count;

        public float rate;
    }

    public Wave[] waves;

    private int nextWave = 0;

    public float timeBetweenWaves = 5f;

    public float waveCountdown;

    private float searchTimer = 1f;

    private SpawnState state = SpawnState.COUNTING; // !! wanneer het script eerst word initialized van dat het gestopt is met tellen. zo dat ik weet dat alles zal werken.

    Boolean repeat;

    Enum Stop;
    void Start()
    {
        waveCountdown = timeBetweenWaves;    
    }

    void Update()
    {
        if(state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                beginNewRound();
            }
            else
            {
                return;
            }
        }
        if(waveCountdown <= 0)
        {
            if(state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));  
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void beginNewRound()
    {
        Debug.Log("Wave Completed");

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if(nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("Wave completed");
        }
        else
        {
            nextWave++;
        }
    }
    bool EnemyIsAlive()
    {
        searchTimer -= Time.deltaTime;
        if(searchTimer <= 0f)
        {
            searchTimer = 1f;
            if(GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }

        return false;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("spawning wave:" +  _wave);
        state = SpawnState.SPAWNING;

        for(int i = 0; i < _wave.enemies.Length; i++) 
        {
            var temp = _wave.enemies[i];
            for(int j = 0; j < temp.count; j++)
            {
                SpawnEnemy(temp.enemyTransform);
                yield return new WaitForSeconds(1f/temp.rate);
            }
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        Instantiate(_enemy, transform.position, transform.rotation);
        Debug.Log("spawning enemy" +_enemy);
    }
}