using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 死亡后重新载入
 */
public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
