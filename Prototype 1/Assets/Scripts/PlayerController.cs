using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 20.0f;
    private float turnSpeed = 5.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // This is where player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput * speed * forwardInput);
    }
}
