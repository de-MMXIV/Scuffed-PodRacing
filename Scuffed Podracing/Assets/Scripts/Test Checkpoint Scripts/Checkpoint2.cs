﻿using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    /// <summary>
    /// sets the checkpoint of the player to the 2 Checkpoint
    /// Florentin Lüdeking
    /// </summary>
    /// <param name="other">the collider</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var setCheckpoint = other.GetComponent<LapManager>();
            setCheckpoint.Checkpoint2 = true;
        }
    }
}
