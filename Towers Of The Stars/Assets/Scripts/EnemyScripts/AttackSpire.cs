using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpire : MonoBehaviour
{
    public bool Attack = false;
    public float attackSpeed;
    public float Damage;
    public float spireHealth;
    public GameObject Bolt;
    public GameObject spire;

    public void Start()
    {
        spireHealth = spire.GetComponent<SpireData>().Health;
    }
    public void Update()
    {
        if(Attack == true)
        {

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("SunSpire"))
        {
            Attack = true;
        }
    }
}
