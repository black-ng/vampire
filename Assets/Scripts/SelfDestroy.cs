using System;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    //子弹攻击到敌人消失
    public void Destroy()
    {
      Destroy(gameObject);  //Unity内建方法，摧毁game object  
    }
}
