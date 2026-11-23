using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuildingObjectPool : MonoBehaviour
{
    [SerializeField] private int _poolSize = 5;
    [SerializeField] private GameObject _arrowTowerPrefab;

    private Queue<GameObject> pool = new Queue<GameObject>();

    private void Awake()
    {
        for(int i = 0; i < _poolSize; i++)
        {
            GameObject arrowTower = Instantiate(_arrowTowerPrefab);
            arrowTower.gameObject.SetActive(false);
            pool.Enqueue(arrowTower);
        }
    }

    public GameObject GetArrowTower(Vector3 position)
    {
        GameObject arrowTower = pool.Dequeue();
        arrowTower.transform.position = position;
        arrowTower.gameObject.SetActive(true);
        //arrowTower.Initialize(this);
        return arrowTower;
    }

    public void ReturnArrowTower(GameObject arrowTower)
    {
        arrowTower.gameObject.SetActive(false);
        pool.Enqueue(arrowTower);
    }
}
