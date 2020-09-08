﻿using UnityEngine;

public class GameManager : MonoBehaviour
{


    #region BallComponent

    private Vector2 startPoint;
    private Vector2 endPoint;
    private Vector2 direction;
    private Vector2 force;
    private float distance;
    [SerializeField] private float pushForce = 4f;

    #endregion


    public static GameManager Instance;
    public Ball ball;

    private Camera cam;

    private bool isDragging;

    [SerializeField] private int jumpCount = 2;
    private bool canJump = true;

    public Trajectory trajectory;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        cam = Camera.main;
        ball.DeactivateRb();
    }

    private void Update()
    {
        if (canJump)
        {

            if (Input.GetMouseButtonDown(0) )
         {
           
                isDragging = true;
                OnDragStart();
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            OnDragEnd();
        }

       
            if (isDragging)
            {
                OnDrag();
            }
        }
        
            
    }

    private void OnDragStart()
    {
        ball.DeactivateRb();
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        trajectory.Show();
      
    }

    private void OnDrag()
    {
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(startPoint, endPoint);
        direction = (startPoint - endPoint).normalized;
        force = direction * distance * pushForce;
        Debug.DrawLine(startPoint, endPoint);
        trajectory.UpdateDots(ball.BallPos, force);
       
    }

    private void OnDragEnd()
    {
        ball.ActivateRb();
        ball.Push(force);
        trajectory.Hide();
        jumpCount--;
        if (jumpCount==0)
        {
            canJump = false;
        }
        Debug.Log(jumpCount);
        
    }

    //ball and drag 

}