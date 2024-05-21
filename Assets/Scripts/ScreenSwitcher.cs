using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        GlobalScoreManager.ResetHighScore();
    }

    public void SwitchSceneGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
