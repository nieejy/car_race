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


    public bool CheckCheckpoints()
    {
        foreach (Checkpoint checkpoint in checkpoints)
        {
            if (!checkpoint.IsChecked)
            {
                return false;
            }
        }    
        return true;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
