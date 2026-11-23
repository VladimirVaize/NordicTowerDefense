using System.Collections.Generic;
using UnityEngine;

public class ArrowTower: IUpgradable
{
    public Queue<GameObject> Levels { get; }
    public int CurrentLevel { get; }
    public int MaxLevel { get; }
    public BuildingState CurrentState { get; }

    public ArrowTower(Queue<GameObject> levels, int currentLevel, BuildingState currentState)
    {
        Levels = levels;
        CurrentLevel = currentLevel;
        MaxLevel = levels.Count;
        CurrentState = currentState;
    }

    public void Initialize()
    {

    }

    public void Upgrade()
    {
        if(CurrentLevel < MaxLevel)
        {
            Debug.Log("Upgrade");
        }
    }
}
