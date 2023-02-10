using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent attack;
    
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

    // 攻击
    private void DealDamage(Collider2D other)
    {
        if (!canAttack) return;
        
        if (other.CompareTag(targetTag))
        {
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            
            TimersManager.SetTimer(this,1,CanAttack);
            canAttack = false;
            attack.Invoke();    // 攻击后触发摧毁自身子弹
        }
    }
    
    private void CanAttack()
    {
        canAttack = true;
    }
}
