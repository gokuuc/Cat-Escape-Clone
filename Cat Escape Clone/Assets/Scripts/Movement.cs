using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController characterController;

    public GameObject pause;

    public float speed = 5f;

    Renderer rend;

    public Material materialp;

    public Material materialy;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materialy;

        if(Costume.yellow == true)
        {
            rend.sharedMaterial = materialy;
        }
        if(Costume.purple == true)
        {
            rend.sharedMaterial = materialp;
        }
    }

    void Update()
    {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            characterController.Move(move * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pause.gameObject.SetActive(true);
        }
    }
}
