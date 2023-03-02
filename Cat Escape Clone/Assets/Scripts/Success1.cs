using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Success1 : MonoBehaviour
{

    static public bool clear_level1 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Success1");
            clear_level1 = true;
        }
    }
}
