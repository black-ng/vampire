using System;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // 攻击  通常挂在玩家身上
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            var damageable = col.GetComponent<Damageable>();
            damageable.TakeDamage(1);
        }
    }
}
