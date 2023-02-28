using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    public GameObject set;
    public GameObject main;


    public void Level0()
    {
        SceneManager.LoadScene("Level0");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Settings()
    {
        set.gameObject.SetActive(true);
        main.gameObject.SetActive(false);
    }
    public void Mainback()
    {
        main.gameObject.SetActive(true);
        set.gameObject.SetActive(false);
    }

}
