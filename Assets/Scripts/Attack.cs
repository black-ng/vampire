using Timers;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // 扣血冷却1秒
    private bool canAttack = true;
    private void OnTriggerEnter2D(Collider2D col)
    {
        DealDamage(col);
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }

    private void DealDamage(Collider2D other)
    {
        if (!canAttack) return;
        
        if (other.CompareTag("Player"))
        {
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            
            TimersManager.SetTimer(this,1,CanAttack);
            canAttack = false;
        }
    }
    
    private void CanAttack()
    {
        canAttack = true;
    }
}
