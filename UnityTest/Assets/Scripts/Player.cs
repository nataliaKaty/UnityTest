using UnityEngine;

public class Player:MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    private Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    
    private void FixedUpdate()
    {
        Vector2 vector2 =GameInput.Instance.GetVector();
        vector2 = vector2.normalized;
        rigidbody2D.MovePosition(rigidbody2D.position + vector2 * (movementSpeed * Time.fixedDeltaTime));
    }
}
