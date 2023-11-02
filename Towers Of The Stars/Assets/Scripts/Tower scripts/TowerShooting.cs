using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    public RangeScript Target;
    public GameObject BulletPrefab;
    public bool Shoot = true;
    public TowerStats stats;

    public void Start()
    {
        Target = GetComponentInChildren<RangeScript>();
        stats = GetComponent<TowerStats>();
    }

    public void Update()
    {
        if (Shoot == true && Target.EnemiesInRange.Count != 0) 
        {
            GameObject Bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            BulletShooting bulletStats = Bullet.GetComponent<BulletShooting>();
            bulletStats.targetPos = Target.EnemiesInRange[0].transform;
            Shoot = false;
            bulletStats.speed = stats.projSpeed;
            bulletStats.damage = stats.damage;
            StartCoroutine(AttackDelay());
        }
    }

    IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(stats.firingSpeed);
        Shoot = true;
    }
}
