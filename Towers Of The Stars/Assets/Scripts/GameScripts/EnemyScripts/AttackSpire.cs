using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpire : MonoBehaviour
{
    public int Damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.CompareTag("SunSpire") && gameObject.tag != "NeutralizedCloud")
        {
            GlobalData.SpireHealth -= Damage;
            Debug.Log(GlobalData.SpireHealth.ToString());
        }
    }
}
