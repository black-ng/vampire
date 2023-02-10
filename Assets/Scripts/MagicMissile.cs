using System;
using Timers;
using UnityEngine;
using UnityEngine.Events;

// 生存成子弹攻击
public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator creator;
    [SerializeField] private UnityEvent missileLaunch;      //增加飞弹音效
    private void LaunchMissile()
    {
        creator.CreateMissile();
        missileLaunch.Invoke();
    }

    private void Awake()
    {
        TimersManager.SetLoopableTimer(this,1,LaunchMissile);
    }
}
