using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  [SerializeField] int sceneBuildIndex = 2;
  string LevelOnExit = "level";
    public void StartScene()
    {
      Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }
    public void RestartLevel()
    {
    Time.timeScale = 1;
      SceneManager.LoadScene(sceneBuildIndex);
    }
    public void Level1()
    {
    Time.timeScale = 1;
      SceneManager.LoadScene("Level 1");
    }

    public void nextlevel()
    {
    Time.timeScale = 1;
    sceneBuildIndex = sceneBuildIndex+1;
    PlayerPrefs.SetInt(LevelOnExit, sceneBuildIndex);
      SceneManager.LoadScene(PlayerPrefs.GetInt(LevelOnExit));
    }

    public void ContinueGame()
    {
      SceneManager.LoadScene(PlayerPrefs.GetInt(LevelOnExit));
    }

    public void GameCompleted()
    {
      Time.timeScale = 1;
        SceneManager.LoadScene("GameCompleted");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
