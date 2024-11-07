using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeScript : MonoBehaviour
{
    Rigidbody rb;
    float ExplosionRadius = 10;
    float ExplosionStrength = 1000;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(100 * transform.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimColliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
        foreach (Collider collider in allVictimColliders)
        {
            person personVictim = collider.GetComponent<person>();
            
                if (personVictim != null)
                {
                personVictim.ExplosionAt(transform.position, ExplosionStrength, ExplosionRadius);
                }
            
            Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(ExplosionStrength,transform.position, ExplosionRadius);
            }
        }

        Destroy(gameObject);
    }
}
