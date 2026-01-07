using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCreator : MonoBehaviour
{
    public GameObject buttonprefab;
    void Start()
    {
        foreach (var item in GameManager.instance.levelDB.levels)
        {
            GameObject button = Instantiate(buttonprefab, transform);
            button.GetComponent<LevelSelectionButton>().Setup(item); //on appelle la fonction setup du bouton pour configurer les infos
        }
    }
}
