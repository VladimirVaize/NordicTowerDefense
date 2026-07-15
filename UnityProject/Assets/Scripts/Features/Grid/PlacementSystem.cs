using NordicTowerDefense.Core.Managers;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] private GameObject _mouseIndicator, _cellIndicator;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private Grid _grid;

    private void Update()
    {
        

        if (_inputManager.IsMap())
        {
            _cellIndicator.SetActive(true);

            Vector3 mousePosition = _inputManager.GetSelectedMapPosition();
            Vector3Int gridPosition = _grid.WorldToCell(mousePosition);
            _mouseIndicator.transform.position = mousePosition;
            _cellIndicator.transform.position = _grid.CellToWorld(gridPosition);
        }
        else
        {
            _cellIndicator.SetActive(false);
        }
    }
}
