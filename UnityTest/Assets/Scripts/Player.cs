using UnityEngine;

public class Player:MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    private Rigidbody2D rigidbody2D;

    public static Player Instance {  get; private set; }
    private float minspeed=0.1f;
    private bool isRunning = false;
    private void Awake()
    {
        Instance = this;    
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    
    private void FixedUpdate()
    {
        HandleMovement();
    }
    private void HandleMovement()
    {

        Vector2 vector2 = GameInput.Instance.GetVector();
        vector2 = vector2.normalized;
        rigidbody2D.MovePosition(rigidbody2D.position + vector2 * (movementSpeed * Time.fixedDeltaTime));

        if(Mathf.Abs(vector2.x)>minspeed|| Mathf.Abs(vector2.y)>minspeed)
        {
            isRunning = true;
        }
        else isRunning = false; 
    }

    public bool IsRunning()
    {
        return isRunning;
    }
}
