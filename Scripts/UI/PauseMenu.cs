using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Bullet_Select.IsPaused)
            {
                resume();
            }
            else
            {
                Paused();
            }
        }
    }
    public void Paused()
    {
        Bullet_Select.IsPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;//pauses menu
    }


    public void resume()
    {
       Bullet_Select.IsPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
    }

    public void Menu()
    {
        Bullet_Select.IsPaused = false;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);//loads title screen
        Time.timeScale = 1f;//menu disapears
    }
}