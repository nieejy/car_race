using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{

    private Checkpoint[] checkpoints;



    // Start is called before the first frame update
    void Start()
    {
        checkpoints = GameObject.FindObjectsOfType<Checkpoint>();
    }

    public void OnCheckPointTriggered()
    {

    }

    private bool CheckIfAllCheckpointsHit()
    {
        foreach(Checkpoint checkpoint in checkpoints)
        {
            if(!checkpoint.IsChecked)
            {
                return false;
            }
        }
        return true;
    }

    private void ResetCheckpoint()
    {
        foreach (Checkpoint checkpoint in checkpoints)
        {
            checkpoint.Reset();
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
