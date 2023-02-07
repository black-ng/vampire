using System;
using DG.Tweening;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private PlayerManager playerManager;

    public void FixedUpdate()
    {
        var playerPosition = playerManager.Position;
        var position = (Vector2) transform.position;
        var direction = playerPosition - position;
        direction.Normalize();
        var targetPosition = position + direction;  // 现在位置
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
