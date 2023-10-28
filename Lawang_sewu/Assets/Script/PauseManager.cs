using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private Button resume;
    [SerializeField] private Button back;

    private Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        resume.onClick.AddListener(Resume);
        back.onClick.AddListener(Back);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.enabled == false)
            {
                canvas.enabled = true;
                Time.timeScale = 0;
            }
            else
            {
                canvas.enabled = false;
                Time.timeScale = 1;
            }
        }
    }

    void Resume()
    {
        canvas.enabled = false;
        Time.timeScale = 1;
    }

    void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }


}
