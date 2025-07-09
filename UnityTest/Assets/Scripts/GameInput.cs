using UnityEngine;

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

}
