using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 0.5f;
    private float rotationSpeed = 100.0f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Moves plane vertically based on vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Plane moving forward at constant speed
        transform.Translate(Vector3.forward * speed);

        // This is where I added verticalInput to change rotation based on input, changed to Vector3.left to map keys to up/down
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime * verticalInput);
    }
}
