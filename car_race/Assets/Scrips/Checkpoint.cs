using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public bool IsChecked = false;
    private CheckpointManager CheckpointManager;


    private void Start()
    {
        CheckpointManager = GameObject.FindObjectOfType<CheckpointManager>();
    }


    

    private void OnTriggerEnter(Collider other)
    {
        IsChecked = true;
    }

    public void Reset()
    {
        IsChecked = false;
    }
}
