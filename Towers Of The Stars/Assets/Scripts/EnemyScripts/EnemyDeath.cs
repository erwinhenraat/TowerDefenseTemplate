using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public EnemyStats stats;
    public BulletShooting BulletStat;
    public float Health;
    public bool HasDied;
    void Start()
    {
        stats= GetComponent<EnemyStats>();
        Health = stats.health;
    }

    private void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Bullet"))
        {
            BulletStat = collision.gameObject.GetComponent<BulletShooting>();


            Debug.Log("Enemy hit!");
            Health -= BulletStat.damage;
            Debug.Log($"Health is now {Health}");
            Destroy(collision.gameObject);
        }

        if(Health <= 0 && !HasDied)
        {
            Destroy(gameObject);

            HasDied = true;
            PointSystem Point = GameObject.Find("PointCanvas").GetComponent<PointSystem>();
            Point.AddPoints(stats.Points);
        }
    }
}
