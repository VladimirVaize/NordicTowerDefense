using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    [SerializeField, Range(10, 20)] private float _speed;
    [SerializeField, Range(25, 50)] private float _maxSpeed;
    [SerializeField, Range(1, 10)] private float _zoomStep;
    [SerializeField, Range(30, 60)] private float _maxCameraHeight;
    [SerializeField, Range(5, 25)] private float _minCameraHeight;
    [SerializeField] private LayerMask _terrainMask;

    private float _currentSpeed;
    private float _currentCameraHeight = 30;
    private InputSystem_Actions _inputSystem;

    private void Awake()
    {
        _inputSystem = new InputSystem_Actions();

        _speed = Math.Min(_speed, _maxSpeed);
        _maxCameraHeight = Math.Max(_minCameraHeight, _maxCameraHeight);
        _currentSpeed = _speed;
        _terrainMask = LayerMask.GetMask("Terrain");
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
        Move();
        CameraZoom();
    }

    private void Move()
    {
        Vector2 moveInput = _inputSystem.Camera.Move.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * Time.deltaTime * _currentSpeed, Space.World);

        float speedBoostInput = _inputSystem.Camera.SpeedBoost.ReadValue<float>();

        if (speedBoostInput > 0.2f)
            _currentSpeed = _maxSpeed;
        else
            _currentSpeed = _speed;
    }

    private void CameraZoom()
    {
        Vector2 zoomInput = _inputSystem.Camera.Zoom.ReadValue<Vector2>();

        if (GetCameraHeight() < 0)
            return;

        if (_currentCameraHeight < _minCameraHeight)
            _currentCameraHeight = _minCameraHeight;

        if (_currentCameraHeight > _maxCameraHeight)
            _currentCameraHeight = _maxCameraHeight;

        float deltaY = _currentCameraHeight - GetCameraHeight();
        Vector3 cameraPosition = gameObject.transform.position;
        cameraPosition.y = Mathf.Lerp(cameraPosition.y, cameraPosition.y + deltaY, Time.deltaTime * 5);
        gameObject.transform.position = cameraPosition;

        if(zoomInput.y < 0)
        {
            _currentCameraHeight = Math.Min(_currentCameraHeight + _zoomStep, _maxCameraHeight);
        }
        else if(zoomInput.y > 0)
        {
            _currentCameraHeight = Math.Max(_currentCameraHeight - _zoomStep, _minCameraHeight); 
        }
    }


    private float GetCameraHeight()
    {
        Vector3 cameraPosition = gameObject.transform.position;
        Vector3 directionToBottom = Vector3.down.normalized;

        Ray ray = new Ray(cameraPosition, directionToBottom);
        RaycastHit hit;
        float maxDistance = 150;

        if(Physics.Raycast(ray, out hit, maxDistance, _terrainMask))
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.green);
            if (hit.collider.CompareTag("Terrain"))
            {
                float cameraHeight = cameraPosition.y - hit.point.y;

                return cameraHeight;
            }
            else
                Debug.Log("NoTerrain");
        }

        return -1;
    }
}
