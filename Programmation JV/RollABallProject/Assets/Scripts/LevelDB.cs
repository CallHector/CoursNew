using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelDB", menuName = "LevelDB", order = 0)]
public class LevelDB : ScriptableObject
{
    public List<levelDataSO> levels;
}
