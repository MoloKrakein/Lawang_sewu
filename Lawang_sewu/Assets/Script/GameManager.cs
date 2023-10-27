using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button start;
    public Button quit;
    void Start()
    {
        start.onClick.AddListener(GameScene);
        quit.onClick.AddListener(QuitGame);
    }

    void GameScene()
    {
        SceneManager.LoadScene("Game Scene");
    }
    void QuitGame()
    {
        Application.Quit();
    }
}
