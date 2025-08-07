using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlatformController platformController;
    [SerializeField] private SpawnManager spawnManager;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI winText;

    public bool isGameActive = true;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    private void FixedUpdate()
    {
        if (spawnManager.brickCount == 0)
        {
            winText.gameObject.SetActive(true);
            isGameActive = false;
        }

        
    }

    
}
