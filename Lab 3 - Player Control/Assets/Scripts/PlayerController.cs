﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 10f;
    private Rigidbody _playerRb;
    private float _horizontalInput;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        _playerRb.AddForce(Vector3.forward * _speed * _verticalInput);
        _playerRb.AddForce(Vector3.right * _speed * _horizontalInput);
    }
}