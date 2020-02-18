using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0f, 400f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-40f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(40f, 0f, 0f);
        }
    }
}
