using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{
    public float BulletSpeed = 5;
    public float damage = 2;
    public Transform targetPos;
    private Vector3 dir;
    public void Start()
    {
        dir = targetPos.position - transform.position;
        dir.Normalize();
    }
    public void Update()
    {
        if (targetPos == null)
        {
            return;
        }
        
        transform.position += dir * Time.deltaTime * BulletSpeed;
    }
}
