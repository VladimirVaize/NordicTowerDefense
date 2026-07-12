using UnityEngine;
using UnityEngine.InputSystem;

namespace NordicTowerDefense.Core.Managers
{
    public sealed class InputManager : MonoBehaviour
    {
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private LayerMask _placementLayermask;

        private Vector3 _lastPosition;


        public Vector3 GetSelectedMapPosition()
        {
            Mouse mouse = Mouse.current;
            if(mouse == null)
            {
                return Vector3.zero;
            }

            Vector2 mousePosition = mouse.position.ReadValue();
            //mousePosition.z = _mainCamera.nearClipPlane;
            Ray ray = _mainCamera.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100, _placementLayermask))
            {
                _lastPosition = hit.point;
            }

            return _lastPosition;
        }
    }
}
