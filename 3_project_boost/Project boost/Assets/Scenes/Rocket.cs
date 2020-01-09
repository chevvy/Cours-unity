using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Space pressed");
            rigidBody.AddRelativeForce(Vector3.up);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Left key pressed");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Right key pressed");
        }
    }
}
