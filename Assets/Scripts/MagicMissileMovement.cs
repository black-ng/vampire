using DG.Tweening;
using UnityEngine;

public class MagicMissileMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 _direction;
    
    // 敌人位置
    private GameObject LocateEnemy()
    {
        var results = new Collider2D[5];
        /*
            在指定的地方画一个圆，圆中的所有object game 都会被找到
            argument：子弹的位置、半径、
         */
        Physics2D.OverlapCircleNonAlloc(transform.position, 10, results);

        foreach (var result in results)
        {
            if (result != null && result.CompareTag("Enemy"))
            {
                return result.gameObject;
            }
        }
        return null;
    }
    
    /*
     * 子弹移动方向
     * 永远要记住，方向=目的位置-现在位置！！！
     */
    private Vector2 MoveDirection(Transform target)
    {
        var direction = new Vector2(1, 0);
        
        if (target != null)
        {
            direction = target.position - transform.position;
            direction.Normalize();
        }

        return direction;
    }

    /*
     * 在游戏一开始侦测敌人位置
     */
    private void Awake()
    {
        var enemy= LocateEnemy();
        if (enemy == null) 
            _direction = MoveDirection(null);
        else
            _direction = MoveDirection(enemy.transform);
        // 调整子弹头瞄准敌人的位置
        transform.rotation = Quaternion.LookRotation(Vector3.forward,_direction);
    }
    
    /*
     * 实际移动
     */
    private void FixedUpdate()
    {
        var targetPosition = (Vector2)transform.position + _direction;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
