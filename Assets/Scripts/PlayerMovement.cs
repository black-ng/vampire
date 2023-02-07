using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rd;
    [SerializeField] private float speed;
    private Vector2 _inputDirection;    // 移動方向


    public void Move(InputAction.CallbackContext context)
    { 
        _inputDirection = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;     //  現在位置
        var targetPosition = position + _inputDirection;    //  移動位置=現在位置+移動方向

        if (position == targetPosition) return;     //修復抖動BUG
        
        rd.DOMove(targetPosition,speed).SetSpeedBased();// 第二個參數是速度，不是時間
    }
}
