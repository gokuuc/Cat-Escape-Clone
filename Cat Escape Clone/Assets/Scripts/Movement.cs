using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (SphereCollider))]
public class Movement : MonoBehaviour
{

    [SerializeField] private Rigidbody _rb;

    [SerializeField] private FixedJoystick _joystick;

    public GameObject pause;

    public float speed = 5f;

    Renderer rend;

    public Material materialp;

    public Material materialy;

    void Start()
    {
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pause.gameObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_joystick.Horizontal * speed, _rb.velocity.y, _joystick.Vertical * speed);
    }
}
