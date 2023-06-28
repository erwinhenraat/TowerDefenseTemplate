using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustAScript : MonoBehaviour
{
    private Rigidbody r;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    private void OnCollisionEnter(Collision collision)
    {
        r.velocity= Vector3.up * force;
    }
}
