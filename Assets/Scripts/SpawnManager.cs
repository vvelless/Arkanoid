using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject brickPrefab;

    private Vector2 spawnPosition = new Vector2(0, -3.74f);

    public int brickCount;
    
    void Start()
    {
        SpawnBall();
        SpawnBricks();
    }
    
    private void SpawnBall()
    {
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    private void SpawnBricks()
    {
        for (float i = 3.5f; i > 0; i -= 0.5f)
        {
            for (float j = 5f; j > 0; j -= 1.5f)
            {
                Instantiate(brickPrefab, new Vector2(j - 2.75f, i + 1), Quaternion.identity);
                brickCount++;

            }
        }
    }
    
    
}
