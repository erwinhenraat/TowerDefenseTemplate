using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public EnemyStats stats;
    public BulletShooting BulletStat;
    public float Health;
    public bool HasDied;
    public GameObject Neutralized;

    void Start()
    {
        stats= GetComponent<EnemyStats>();
        Health = stats.health;
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
            //Destroy(gameObject);

            HasDied = true;
            PointSystem Point = GameObject.Find("PointCanvas").GetComponent<PointSystem>();
            Point.AddPoints(stats.Points);
            GetComponent<Animator>().SetBool("IsDead", true);
            gameObject.GetComponent<SpriteRenderer>().sprite = Neutralized.GetComponent<SpriteRenderer>().sprite;
            gameObject.tag = Neutralized.tag;

        }
    }
}
