using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float acceleration = 1.5f;
    public float steering = 1;
    public bool drifting = false;
    private bool isPaused = false;
    Rigidbody ridgid;


    // Start is called before the first frame update
    void Start()
    {
        ridgid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) { ResumeGame(); }
            else { PauseGame(); }
        }

        if(!isPaused)
        {
            float verticalInput = Input.GetAxis("Vertical");
            float hoizontalInput = Input.GetAxis("Horizontal");

            ridgid.AddForce(transform.forward * verticalInput * acceleration * Time.deltaTime);
            transform.Rotate(Vector3.up, hoizontalInput * steering * Time.deltaTime);

            if (drifting == false)
            {
                Vector3 velocity = ridgid.velocity;
                velocity = transform.forward * velocity.magnitude;
                ridgid.velocity = velocity;
            }
        }

        


    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        Debug.Log("Pausiert");
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        Debug.Log("Fortgesetzt");
    }
}
