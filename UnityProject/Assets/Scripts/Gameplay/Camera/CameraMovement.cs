using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxSpeed;

    private float _currentSpeed;
    private InputSystem_Actions _inputSystem;

    private void Awake()
    {
        _inputSystem = new InputSystem_Actions();

        _speed = Math.Min(_speed, _maxSpeed);
        _currentSpeed = _speed;
    }

    private void OnEnable()
    {
        _inputSystem.Camera.Enable();
    }

    private void OnDisable()
    {
        _inputSystem.Camera.Disable();
    }

    private void Update()
    {
        Vector2 moveInput = _inputSystem.Camera.Move.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * Time.deltaTime * _currentSpeed);

        float speedBoostInput = _inputSystem.Camera.SpeedBoost.ReadValue<float>();

        if (speedBoostInput > 0.2f)
            _currentSpeed = _maxSpeed;
        else
            _currentSpeed = _speed;
    }
}
