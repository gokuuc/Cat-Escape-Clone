using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Costume : MonoBehaviour
{
    static public bool purple = false;
    static public bool yellow = true;
    public GameObject Purpleselect;
    public GameObject Yellowselect;

    public void changepurple()
    {
        if(Success1.clear_level1 == true)
        {
            yellow = false;
            purple = true;
            Purpleselect.gameObject.SetActive(false);
            Yellowselect.gameObject.SetActive(true);
        }
    }

    public void changeyellow()
    {
        yellow = true;
        purple = false;
        Purpleselect.gameObject.SetActive(true);
        Yellowselect.gameObject.SetActive(false);
    }
}
