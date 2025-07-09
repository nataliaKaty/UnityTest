using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;
    const string IS_RUNNING = "IsRunning";
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        animator.SetBool(IS_RUNNING, Player.Instance.IsRunning());
        AdjustPlayerFacingDirection();
    }
    private void AdjustPlayerFacingDirection()
    {
        Vector3 mousePos=GameInput.Instance.GetMousePosition();
        Vector3 playerPos= GameInput.Instance.GetPlayerScreenPosition();
        if (mousePos.x < playerPos.x)
        {
            spriteRenderer.flipX=true;
        }
        else spriteRenderer.flipX=false;
    }
}
