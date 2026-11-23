using System.Collections.Generic;
using UnityEngine;

public interface IUpgradable
{
    Queue<GameObject> Levels { get; }
    int CurrentLevel { get; }
    int MaxLevel { get; }
    BuildingState CurrentState { get; }

    void Upgrade();
}