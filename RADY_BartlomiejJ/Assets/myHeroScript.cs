using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    float runSpeed = 6f;
    float turnSpeed = 90f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
                transform.position += runSpeed * transform.forward * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.A))
                transform.position -= runSpeed * transform.right * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.D))
                transform.position += runSpeed * transform.right * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.S))
                transform.position -= runSpeed * transform.forward * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.E))
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        {
            if (Input.GetKey(KeyCode.Q))
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        {
            if (Input.GetKey(KeyCode.Space))
                transform.position += runSpeed * transform.up * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.LeftControl))
                transform.position -= runSpeed * transform.up * Time.deltaTime;
        }

        {
          
                
        }
    }
}
