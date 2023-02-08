using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Health health;

    private void UpdateUI()
    {
        healthBar.value = health.Value;
    }
    
    //  血量初始化
    private void Awake()    //Awake是進入游戲瞬間執行的代碼
    {
        healthBar.maxValue = health.Value;
        healthBar.value = health.Value;
    }
}
