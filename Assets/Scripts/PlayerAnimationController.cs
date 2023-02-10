using UnityEngine;
using UnityEngine.InputSystem;

/*
 * 控制玩家动画
 * Animator 负责控制玩家动画的component
 * sprite render 控制玩家样子
 */
public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private string walkState;       // 走路动画
    [SerializeField] private string idleState;       // 待机动画
    [SerializeField] private string attackState;     // 攻击动画  

    public void Move(InputAction.CallbackContext context)
    {
        // 通过readValue读取移动方向
        var direction = context.ReadValue<Vector2>();
        if (direction == Vector2.zero)
        {
            animator.Play(idleState);
        }
        else
        {
            animator.Play(walkState);
        }
        //解决角色移动，朝向朝右问题
        if (direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }

    }

    public void Attack()
    {
        animator.Play(attackState);
    }
    
}
