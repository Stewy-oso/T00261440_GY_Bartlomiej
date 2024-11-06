using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontrol : MonoBehaviour
{
    public GameObject carrotCloneTemplate;
    public GameObject Cube;
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position += speed * fpsMovementDir * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position -= speed * fpsMovementDir * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 fpsMovementDir = new Vector3(transform.right.y, 0, transform.right.z);
            fpsMovementDir.Normalize();
            transform.position += speed * fpsMovementDir * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 fpsMovementDir = new Vector3(transform.right.y, 0, transform.right.z);
            fpsMovementDir.Normalize();
            transform.position -= speed * fpsMovementDir * Time.deltaTime;
        }

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);

        transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(carrotCloneTemplate, transform.position, transform.rotation); 
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(Cube, transform.position, transform.rotation);
        }
    }
}
