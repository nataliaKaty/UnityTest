using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
   public static GameInput Instance { get; private set; }
    private PlayerInputActions inputActions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Instance = this;
        inputActions = new PlayerInputActions();
        inputActions.Enable();
    }
    public Vector2 GetVector()
    {
        Vector2 vector2 = inputActions.Player.Move.ReadValue<Vector2>();
        return vector2;
    }

    public Vector3 GetMousePosition()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        return mousePos;
    }

    public Vector3 GetPlayerScreenPosition()
    {
        Vector3 playerPos=Camera.main.WorldToScreenPoint(transform.position);
        return playerPos;
    }
}
