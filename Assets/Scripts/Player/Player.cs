using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private InputPlayer _inputPlayer;
    private Rigidbody2D _rb;
    private float _movingSpeed = 5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _inputPlayer = new InputPlayer();
        _inputPlayer.Enable();
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = GetMovementVector();
        _rb.MovePosition(_rb.position + inputVector * (_movingSpeed * Time.deltaTime));
    }

    private Vector2 GetMovementVector()
    {
        Vector2 inputVector = _inputPlayer.Player.Move.ReadValue<Vector2>();
        return inputVector;
    }
}
