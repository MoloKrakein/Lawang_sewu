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
        // wait 1 seconds
        StartCoroutine(LoadGameScene());
    }
    void QuitGame()
    {
       StartCoroutine(LoadQuitGame());
    }

    // 2 Second Timer before load GameScene
    IEnumerator LoadGameScene(){
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level2");
    }
    
    IEnumerator LoadQuitGame(){
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
