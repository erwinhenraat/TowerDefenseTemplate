using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    public RangeScript Target;
    public GameObject BulletPrefab;
    public float AttackSpeed = 5;
    public bool Shoot = true;

    public void Start()
    {
        Target = GetComponentInChildren<RangeScript>();
    }

    public void Update()
    {
        if (Shoot == true && Target.EnemiesInRange.Count != 0) 
        {
            GameObject Bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            Bullet.GetComponent<BulletShooting>().targetPos = Target.EnemiesInRange[0].transform;
            Shoot = false;
            StartCoroutine(AttackDelay());
        }
    }

    IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(AttackSpeed);
        Shoot = true;
    }
}
