using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    private Rigidbody2D playerRb;
    private PlayerInput playerInput;
    private InputAction moveAction;
    
    private float vectorDirection;
    private float playerSpeed = 10f;
    private float rangeX = 2.3f;

    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions.FindAction("Move");
    }

    void OnMove()
    {
        vectorDirection = moveAction.ReadValue<float>();
        if (playerRb.transform.position.x < -rangeX)
        {
            playerRb.position = new Vector2(-rangeX, -4);
        }
        
        if (playerRb.transform.position.x > rangeX)
        {
            playerRb.position = new Vector2(rangeX, -4);
        }
        
        
        playerRb.velocity = new Vector2(vectorDirection * playerSpeed, playerRb.velocity.x);
        
          
    }
    
    

    void Update()
    {
        if(gameManager.isGameActive) OnMove();
    }

    
}
