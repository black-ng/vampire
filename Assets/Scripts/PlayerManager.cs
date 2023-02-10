using System;
using UnityEngine;
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private static PlayerManager _instance; // static 修复Player Manager为null
    
    public static Vector2 Position
    {
        get { return _instance.playerTransform.position; }
    }

    private void Awake()
    {
        _instance = this;
    }
}