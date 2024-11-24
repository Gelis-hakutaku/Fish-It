using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    [SerializeField] private GameObject pauseMenuUI;
    private string currentScene;


    public void Start()
    {
        pauseMenuUI.SetActive(false);
        currentScene = SceneManager.GetActiveScene().name;
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
        Cursor.visible = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
        Cursor.visible = true;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(currentScene);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        gamePaused = false;
    }
}

