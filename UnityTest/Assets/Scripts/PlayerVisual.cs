using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;
    const string IS_RUNNING = "IsRunning";

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        animator.SetBool(IS_RUNNING, Player.Instance.IsRunning());
    }
}
