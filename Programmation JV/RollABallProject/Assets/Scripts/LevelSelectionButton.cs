using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelectionButton : MonoBehaviour
{

    public string sceneName;
    [SerializeField] private TextMeshProUGUI levelText;
    public Image thumbnailImage;
    levelDataSO myLevel;

    public void LoadLevel()
    {
        GameManager.instance.levelData = myLevel; //on assigne le leveldataSO du game manager
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    //configure les différentes infos du bouton avec le leveldataSO
    public void Setup(levelDataSO levelData)
    {
        myLevel = levelData;
        sceneName = levelData.sceneName;
        thumbnailImage.sprite = levelData.levelThumbnail;
        if (levelText != null)
        {
            levelText.text = levelData.sceneName; // levelText affiche le nom du level
        }
    }

    public void LevelSelectButton()
    {
       
    }

    public void BackButton()
    {

    }
}

