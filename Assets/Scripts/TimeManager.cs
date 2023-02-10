using UnityEngine;

/*
 * 控制时间流速,gamer over时暂停时间
 */
public class TimeManager : MonoBehaviour
{
    public void Stop()
    {
        Time.timeScale = 0;
    }
    
    // 修正死亡后不会动，时间流逝改为1
    public void Resume()
    {
        Time.timeScale = 1;
    }
}
