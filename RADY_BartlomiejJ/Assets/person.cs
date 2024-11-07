using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    int Health = 100;
    int damage = 15;
    Rigidbody rb;
    internal void ExplosionAt(Vector3 position, float explosionStrength, float explosionRadius)
    {
        throw new NotImplementedException();

        Health -= damage;
        print("Ouchie my hp low" + Health.ToString());
        rb.AddExplosionForce(explosionStrength, position, explosionRadius);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
