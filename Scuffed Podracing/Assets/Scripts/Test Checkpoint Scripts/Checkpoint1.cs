﻿using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var setCheckpoint = other.GetComponent<LapManager>();
            setCheckpoint.Checkpoint1 = true;
        }
    }
}
