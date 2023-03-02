using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject Pausee;

    public void Resume()
    {
        Time.timeScale = 1f;
        Pausee.gameObject.SetActive(false);
    }
    public void Mainn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
