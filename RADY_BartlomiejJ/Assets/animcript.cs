using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcript : MonoBehaviour
{
    Animator protoAnim;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        protoAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        protoAnim.SetBool("isGreeting", false);

        if (Input.GetKeyDown(KeyCode.T))
        {
            //Make Prototype greet (Animation)
            protoAnim.SetBool("isGreeting", true);

        }

        protoAnim.SetBool("isFalling", false);

        if (Input.GetKey(KeyCode.LeftControl))
        {
            //Make Prototype simulate falling
            protoAnim.SetBool("isFalling", true);
        }
    }
}
