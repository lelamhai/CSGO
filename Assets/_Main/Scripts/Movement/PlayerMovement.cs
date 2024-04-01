using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private float _speed = 2f;


    private void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    public void HandleMovement(Transform camera, Vector2 input)
    {
        _moveDirection = camera.forward * input.y;
        _moveDirection = _moveDirection + camera.right * input.x;

        _moveDirection.y = 0;

        _moveDirection = _moveDirection * _speed;
        Vector3 movementVelocity = _moveDirection;
        _rigidbody.velocity = movementVelocity;
    }    
}