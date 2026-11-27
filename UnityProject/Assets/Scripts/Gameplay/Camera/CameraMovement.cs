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
    [SerializeField] private float _angleSpep;
    [SerializeField] private float _maxCameraAngle;
    [SerializeField] private float _minCameraAngle;
    [SerializeField] private LayerMask _terrainMask;

    private float _currentSpeed;
    private float _currentCameraHeight = 30;
    private float _currentCameraAngle = 45;
    private Vector2 _startMousePosForChangeAngle;
    private Vector2 _mousePosition;
    private Vector2 _currentScreenResolution;
    private InputSystem_Actions _inputSystem;

    private void Awake()
    {
        _inputSystem = new InputSystem_Actions();

        _speed = Math.Min(_speed, _maxSpeed);
        _maxCameraHeight = Math.Max(_minCameraHeight, _maxCameraHeight);
        _currentSpeed = _speed;
        _terrainMask = LayerMask.GetMask("Terrain");
        
        _currentScreenResolution = new Vector2(Screen.width, Screen.height);
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

        float angleInput = _inputSystem.Camera.Angle.ReadValue<float>();
        _mousePosition = Mouse.current.position.ReadValue();

        //Debug.Log(_mousePosition);
        Debug.Log(_currentScreenResolution.x + " " + _currentScreenResolution.y);

        //Добавить смену вертикального угла камеры
        //(float angleInput - Нажатие кнопки: 0-1,
        //float _maxCameraAngle, _minCameraAngle - Ограничение градуса камеры,
        //_angleSpep - Шаг смены градуса камеры,
        //_currentCameraAngle - Текущий градус камеры,
        //_startMousePosForChangeAngle - Точка с которой началось смена градуса для отслеживания направления - ПЕРЕИМЕНОВАТЬ!!!)
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

        //Добавить перемещение при косании курсора края экрана
        //(Vector2 _currentScreenResolution - Разрешение окна,
        //Vector2 _mousePosition - Текущяя позиция курсора)
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
