using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputCallback _input;

    [SerializeField] private float _speedMove;
    [SerializeField] private float _dashForce;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        if (_input.InputDash)
        {
            if (_input.InputMove == Vector2.zero)
                HandleDash(_input.InputMove);

            else
            {
                HandleDash(_rigidbody.velocity.normalized);
            }
        }
        else
        {
            HandleMove(_input.InputMove);
        }
    }

    private void HandleMove(Vector2 moveDir)
    {
        _rigidbody.velocity = moveDir * _speedMove;
    }

    private void HandleDash(Vector2 moveDir)
    {
        _rigidbody.velocity = moveDir * _dashForce;
    }
}
