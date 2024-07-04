using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // 定义一个方法用于加载目标场景
    public void LoadTargetScene(string sceneName)
    {
        // 使用SceneManager加载目标场景
        SceneManager.LoadScene(sceneName);
    }
}