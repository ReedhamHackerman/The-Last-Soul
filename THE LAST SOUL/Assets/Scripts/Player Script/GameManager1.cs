using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Ball ball;
    [SerializeField] public float pushForce;
    private Camera cam;
    private bool canJump = true;
    public TimeManager timeManager;
    private bool isDragging;
  
    [SerializeField] private int jumpCount = 2;

    public Trajectory trajectory;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        Debug.Log(Time.timeScale);
        cam = Camera.main;
        ball.DeactivateRb();
    }

    private void Update()
    {


        ball.WinningCondion();

        if (canJump)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isDragging = true;
                OnDragStart();

            }
            if (Input.GetMouseButtonUp(0))
            {
                isDragging = false;
                OnDragEnd();
            }
            if (isDragging) OnDrag();
        }
       if(Input.GetKeyDown(KeyCode.J))
        {
            ball.NextScene();
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
        timeManager.DoSlowMotion();
    }

    private void OnDragEnd()
    {
        ball.ActivateRb();
        ball.Push(force);
        trajectory.Hide();
        jumpCount--;
        if (jumpCount == 0) canJump = false;
        Debug.Log(jumpCount);
        do
        {
            Debug.Log(Time.timeScale);
            Time.timeScale += 0.825f;

            Debug.Log(Time.timeScale);
        } while (Time.timeScale >= 2f);

    }


    #region BallComponent

    private Vector2 startPoint;
    private Vector2 endPoint;
    private Vector2 direction;
    private Vector2 force;
    private float distance;


    #endregion

   
}