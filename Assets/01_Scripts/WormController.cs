using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    private Rigidbody rbA;
    private Rigidbody rbB;
    private bool isLeft;

    [SerializeField] private GameObject playerA;
    [SerializeField] private GameObject BazookaA;

    [SerializeField] private GameObject playerB;
    [SerializeField] private GameObject BazookaB;
    void Start()
    {
        rbA = playerA.GetComponent<Rigidbody>();
        rbB = playerB.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //ONE
        //move
        if (Input.GetKeyDown(KeyCode.W))
        {
            rbA.AddForce(0f, 400f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rbA.AddForce(-40f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rbA.AddForce(40f, 0f, 0f);
        }
        //shoot 
        if (Input.GetKeyDown(KeyCode.S))
        {
            BazookaA.GetComponent<BazookaShoot>().Shoot();
        }
        //TWO
        //move
        if (Input.GetKeyDown(KeyCode.I))
        {
            rbB.AddForce(0f, 400f, 0f);
        }

        if (Input.GetKey(KeyCode.J))
        {
            rbB.AddForce(-40f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.L))
        {
            rbB.AddForce(40f, 0f, 0f);
        }
        //shoot
        if (Input.GetKeyDown(KeyCode.K))
        {
            BazookaB.GetComponent<BazookaShoot>().Shoot();
        }

    }
}
