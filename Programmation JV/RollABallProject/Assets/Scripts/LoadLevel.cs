using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string LevelToLoad;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
           SceneManager.LoadScene(LevelToLoad); //charge le niveau par nom
          // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //restart le niveau en cours
        }
    }
}
