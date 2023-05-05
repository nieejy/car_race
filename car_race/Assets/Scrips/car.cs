using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float acceleration = 1.5f;
    public float steering = 1;
    Rigidbody ridgid;


    // Start is called before the first frame update
    void Start()
    {
        ridgid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float hoizontalInput = Input.GetAxis("Horizontal");

        ridgid.AddForce(transform.forward * verticalInput * acceleration * Time.deltaTime);
        transform.Rotate(Vector3.up, hoizontalInput * steering * Time.deltaTime);

        Vector3 velocity = ridgid.velocity;
        velocity = transform.forward * velocity.magnitude;
        ridgid.velocity = velocity;
    }
}
