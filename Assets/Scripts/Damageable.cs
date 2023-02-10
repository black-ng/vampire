using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private UnityEvent damaged;     // 受伤音效
    
    private Color _defaultColor;
    
    //受伤，Player显示为红色
    public void TakeDamage(int damage)
    {
        health.DecreaseHealth(damage);
        spriteRenderer.DOColor(Color.red, 0.2f).SetLoops(2,LoopType.Yoyo)
            .ChangeStartValue(_defaultColor);
        damaged.Invoke();
    }

    private void Awake()
    {
        _defaultColor = spriteRenderer.color;
    }
}
