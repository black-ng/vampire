using UnityEngine;
using UnityEngine.Events;

//死亡功能
public class Death : MonoBehaviour
{
    [SerializeField] private UnityEvent died;
    
    public void CheckDeath(int health)
    {
        if (health <= 0)
            Die();
    }
    
    private void Die()
    {
        gameObject.SetActive(false);
        died.Invoke();
    }
}
