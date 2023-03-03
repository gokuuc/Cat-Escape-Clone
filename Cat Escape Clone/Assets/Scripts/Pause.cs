using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject Pausee;
    public GameObject PauseB;
    public GameObject Analog;

    public void Resume()
    {
        Time.timeScale = 1f;
        Pausee.gameObject.SetActive(false);
        PauseB.gameObject.SetActive(true);
        Analog.gameObject.SetActive(true);
    }
    public void Mainn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void PMenu()
    {
        PauseB.gameObject.SetActive(false);
        Pausee.gameObject.SetActive(true);
        Analog.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }
}
