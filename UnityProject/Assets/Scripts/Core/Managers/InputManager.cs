using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NordicTowerDefense.Core.Managers
{
    public sealed class InputManager : MonoBehaviour
    {
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private LayerMask _placementLayermask;

        public event Action OnClicked, OnExit;

        private InputControls _inputSystem;
        private Vector3 _lastPosition;
        private Mouse _mouse = Mouse.current;

        private void Awake()
        {
            if (_mouse == null)
            {
                Debug.LogError("Mause is not found!");
                enabled = false;
            }

            _inputSystem = new InputControls();

            _inputSystem.Gameplay.Select.performed += 
        }

        private void Update()
        {
            
        }

        public Vector3 GetSelectedMapPosition()
        {
            Vector2 mousePosition = _mouse.position.ReadValue();
            Ray ray = _mainCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100, _placementLayermask))
            {
                _lastPosition = hit.point;
            }

            return _lastPosition;
        }

        public bool IsMap()
        {
            Vector2 mousePosition = _mouse.position.ReadValue();
            Ray ray = _mainCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, _placementLayermask))
            {
                return true;
            }

            return false;
        }
    }
}
