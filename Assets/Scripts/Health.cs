using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private UnityEvent healthChanged;
    public int Value
    {
        get { return health; }
    }

    // 减少血量
    public void DecreaseHealth(int amount)
    {
        health -= amount;
        healthChanged.Invoke();
    }
}