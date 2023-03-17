using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

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
        ridgid.AddForce(transform.forward * verticalInput * 10);
    }
}
