using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace NordicTowerDefense.Core.Managers
{
    public sealed class InputManager : MonoBehaviour
    {
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private LayerMask _placementLayermask;

        public event Action OnClicked, OnExit;

        private Vector3 _lastPosition;
        private Mouse _mouse = Mouse.current;
        private Keyboard _keyboard = Keyboard.current;

        private void Awake()
        {
            if (_mouse == null)
            {
                Debug.LogError("Mause is not found!");
                enabled = false;
            }

            if (_keyboard == null)
            {
                Debug.LogError("Keyboard is not found!");
                enabled = false;
            }
        }

        private void Update()
        {
            if (_mouse.leftButton.wasPressedThisFrame)
            {
                OnClicked?.Invoke();
            }

            if (_keyboard.escapeKey.wasPressedThisFrame)
            {
                OnExit?.Invoke();
            }
        }

        public bool IsPointerOverUI() => EventSystem.current.IsPointerOverGameObject();

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
