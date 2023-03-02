using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{

    public GameObject set;
    public GameObject main;
    public GameObject playmenu;

    public GameObject button_Level1;
    public GameObject button_Level2;
    public GameObject button_Level3;

    public GameObject Costumemenu;

    public GameObject Purpleselect;


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
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
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
    public void Play()
    {
        playmenu.gameObject.SetActive(true);
        main.gameObject.SetActive(false);
        if (Success.clear_level0 == true)
        {
            button_Level1.GetComponent<Image>().color = Color.green;
            button_Level2.GetComponent<Image>().color = Color.white;
        }
        if (Success1.clear_level1 == true)
        {
            button_Level2.GetComponent<Image>().color = Color.green;
            button_Level3.GetComponent<Image>().color = Color.white;
        }
        if (Success2.clear_level2 == true)
        {
            button_Level3.GetComponent<Image>().color = Color.green;
        }
    }
    public void PlayBack()
    {
        main.gameObject.SetActive(true);
        playmenu.gameObject.SetActive(false);
    }
    public void Costume()
    {
        Costumemenu.gameObject.SetActive(true);
        main.gameObject.SetActive(false);
        if (Success1.clear_level1 == true)
        {
            Purpleselect.GetComponent<Image>().color = Color.white;
        }
    }
    public void Costumeback()
    {
        main.gameObject.SetActive(true);
        Costumemenu.gameObject.SetActive(false);
    }
    public void Clevel0()
    {
        if (Success.clear_level0 == true)
        {
            Debug.Log("You Are Already Escaped From Level 1!");
        }
        else
        {
            SceneManager.LoadScene("Level0");
        }
    }
    public void Clevel1()
    {
        if (Success.clear_level0 == true && Success1.clear_level1 == true)
        {
            Debug.Log("You Are Already Escaped From Level 2!");
        }
        if (Success.clear_level0 == true && Success1.clear_level1 == false)
        {
            SceneManager.LoadScene("Level1");
        }
    }
    public void Clevel2()
    {
        if (Success1.clear_level1 == true && Success2.clear_level2 == false)
        {
            SceneManager.LoadScene("Level2");
        }
        if (Success1.clear_level1 == true && Success2.clear_level2 == true)
        {
            Debug.Log("You Are Already Escaped From Level 3!");
        }
    }
}
