using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushStartButton()
    {
        SceneManager.LoadScene("");
    }

    public void PushEndButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // エディターの場合
#else
Application.Quit(); // 実行ファイルの場合
#endif
    }

}
