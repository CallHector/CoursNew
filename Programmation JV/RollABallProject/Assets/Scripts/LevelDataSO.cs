using UnityEngine;

[CreateAssetMenu(fileName = "LevelDataSO", menuName = "LevelDataSO", order = 0)]

public class levelDataSO : ScriptableObject
{
    public float ballSpeed;
    public float ballRespawnAltitude;
    public string sceneName;
    public Sprite levelThumbnail;
}
