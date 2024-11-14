using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.UIElements;

public class FPScontrol : MonoBehaviour
{
    public GameObject carrotCloneTemplate;
    public GameObject Cube;
    float speed = 3;
    public float yMaxLimit = 45;
    public float yMinLimit = -45;
    float yRotateC = 0;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
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
            Vector3 fpsMovementDir = new Vector3(transform.right.x, 0, transform.right.z);
            fpsMovementDir.Normalize();
            transform.position += speed * fpsMovementDir * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 fpsMovementDir = new Vector3(transform.right.x, 0, transform.right.z);
            fpsMovementDir.Normalize();
            transform.position -= speed * fpsMovementDir * Time.deltaTime;
        }

       if (Input.GetKey(KeyCode.Space))
        {
            Vector3 fpsMovementDir = new Vector3(0, transform.up.y, 0);
            fpsMovementDir.Normalize();
            transform.position += speed * fpsMovementDir * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            Vector3 fpsMovementDir = new Vector3(0, transform.up.y, 0);
            fpsMovementDir.Normalize();
            transform.position -= speed * fpsMovementDir * Time.deltaTime;
        }

            transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);

            transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

        // Tried limiting Y camera rotation, however it doesn't work (Tried to learn Mathf.Clamp)
        //yRotateC = Mathf.Clamp(yRotateC, yMinLimit, yMaxLimit);

        //yRotateC += Input.GetAxis("Vertical");
        //yRotateC = Mathf.Clamp (yRotateC, yMinLimit, yMaxLimit);
        //transform.eulerAngles = new Vector3(0, -yRotateC, 0) * Time.deltaTime;

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
