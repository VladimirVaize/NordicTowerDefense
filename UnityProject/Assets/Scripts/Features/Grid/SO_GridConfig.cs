using UnityEngine;

[CreateAssetMenu(fileName = "SO_GridConfig", menuName = "Scriptable Objects/SO_GridConfig")]
public class SO_GridConfig : ScriptableObject
{
    public int GridSize { get; private set; } = 2;

}
