using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject submenu;
    public GameObject timer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            submenu.SetActive(!submenu.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            timer.SetActive(!timer.activeSelf);
        }
    }

    public void ShowEsc()
    {
        Time.timeScale = 0;
        submenu.SetActive(!submenu.activeSelf);
    }

    public void QuitEsc()
    {
        Time.timeScale = 1;
        submenu.SetActive(!submenu.activeSelf);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoTitle()
    {
        SceneManager.LoadScene(0);
    }

    public void Mute(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
