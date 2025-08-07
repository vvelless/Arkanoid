using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private SpawnManager spawnManager;
    
    private void Start()
    {
       spawnManager = FindObjectOfType<SpawnManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        spawnManager.brickCount--;  
    }
    
}
