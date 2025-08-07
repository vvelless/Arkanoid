using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    private GameManager gameManager;
    
    private Rigidbody2D ballRb;
    private Vector2 ballStartDirection;
    private float maxMagnitude = 7;
    private float minMagnitude = 5;
    private float ballSpeed = 5;
    private float startAngleRange = 30f;
    
    
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        
        gameManager = GameObject.Find("Sensor").GetComponent<GameManager>();

        ballStartDirection = new Vector3(Random.Range(-startAngleRange, startAngleRange), Random.Range(-startAngleRange, startAngleRange));
        ballRb.velocity = ballStartDirection.normalized * ballSpeed;
        
    }

    private void FixedUpdate()
    {
        
        if (ballRb.velocity.magnitude > maxMagnitude)
        {
            ballRb.velocity = ballRb.velocity.normalized * ballSpeed;
        }

        if (ballRb.velocity.magnitude < minMagnitude)
        {
            ballRb.velocity = ballRb.velocity.normalized * ballSpeed;
        }

        if (!gameManager.isGameActive) ballRb.velocity = new Vector2(0,0);



    }
}
