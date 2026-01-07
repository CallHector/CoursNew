using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public CamBehaviour cam;
    public GameObject ball;

    //database des niveaux
    public LevelDB levelDB;

    //niveau en cours

    public levelDataSO levelData;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject); //ne pas détruire quand on change de scène
    }
    
}


