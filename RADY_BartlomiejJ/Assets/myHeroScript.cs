using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    float runSpeed = 6f;
    float turnSpeed = 90f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
            {
                Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
                fpsMovementDir.Normalize();
                transform.position += runSpeed * fpsMovementDir * Time.deltaTime;
            }
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
            {
                Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
                fpsMovementDir.Normalize();
                transform.position -= runSpeed * fpsMovementDir * Time.deltaTime;
            }
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
                //transform.position += runSpeed * transform.up * Time.deltaTime;
                rb.AddForce(new Vector3(0, 2, 0));
        }

        {
            if (Input.GetKey(KeyCode.LeftControl))
                transform.position -= runSpeed * transform.up * Time.deltaTime;
        }

        {
            transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);

            transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

        }
    }
}
