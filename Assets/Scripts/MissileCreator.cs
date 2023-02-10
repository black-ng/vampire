using Unity.Mathematics;
using UnityEngine;

/*
 * 系统的生成魔法飞弹
 */
public class MissileCreator : MonoBehaviour
{
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private Transform playerTransform;
    
    public void CreateMissile()
    {
        Instantiate(missilePrefab, playerTransform.position, Quaternion.identity);
    }
}
