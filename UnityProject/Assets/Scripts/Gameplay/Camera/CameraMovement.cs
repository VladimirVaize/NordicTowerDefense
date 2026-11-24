using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    //Ускорение не работает...
    //Переделать также как и Move в Update()
    //Перенести содержимое SpeedBoost(), LateUpdate()

    [SerializeField] private float _speed;
    [SerializeField] private float _maxSpeed;

    private float _currentSpeed;
    private InputSystem_Actions _inputSystem;

    private void Awake()
    {
        _inputSystem = new InputSystem_Actions();

        _inputSystem.Camera.SpeedBoost.performed += SpeedBoost;

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
    }

    private void LateUpdate()
    {
        _currentSpeed = _speed;
    }

    private void SpeedBoost(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _currentSpeed = _maxSpeed;
        }
    }
}
