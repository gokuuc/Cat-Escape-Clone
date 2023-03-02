using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Success2 : MonoBehaviour
{
    static public bool clear_level2 = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Success2");
            clear_level2 = true;
        }
    }
}
