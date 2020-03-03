﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazookaShoot : MonoBehaviour
{
    private GameObject bulletInst;

    public GameObject bullet;

    public GameObject bulletSpawnCube;

    private Vector3 gunCubeSpawnPos;

    private Quaternion gunCubeSpawnRot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            gunCubeSpawnPos = bulletSpawnCube.transform.position;
            gunCubeSpawnRot = bulletSpawnCube.transform.rotation;
            bulletInst = Instantiate(bullet, gunCubeSpawnPos, gunCubeSpawnRot) as GameObject;
            Rigidbody rbShoot = bulletInst.GetComponent<Rigidbody>();
            rbShoot.AddForce(transform.up * -500f);
        }
    }

}
