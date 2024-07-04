using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public SceneLoader sceneLoader;

    // 当按钮被点击时调用的方法
    public void OnButtonClick()
    {
        // 调用SceneLoader中的方法来加载目标场景
        sceneLoader.LoadTargetScene("Main");
    }
}