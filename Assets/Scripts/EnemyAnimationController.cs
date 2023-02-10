using Unity.Mathematics;
using UnityEngine;

// 负责控制敌人动画
public class EnemyAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string moveState;

    public void Move(Vector2 direction)
    {
        // 决定动画方向(左/右)
        if (direction.x > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        animator.Play(moveState);
    }
}

