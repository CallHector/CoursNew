using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GestionnaireJeu;

public class GestionnaireJeu : MonoBehaviour
{
    public List<GameObject> animal;

    private void Start()
    {
        InvokeRepeating(nameof(CreationAnimal), 2f, 1f); //après 2 seconde, spawn un animal toutes les 1 seconde
    }
    private void Update()
    {
        //CreationAnimal();  
    }

    void CreationAnimal()
    {
        GameObject animalchoisi = animal[Random.Range(0, animal.Count)];
        /*if (Input.GetKeyDown(KeyCode.C)) //spawn un animal via une touche
        {
            Vector3 randomposition = new Vector3(Random.Range(-23f, 23f), 0, 0);
            Instantiate(animal, randomposition, this.transform.rotation); //spawn un animal à une position aléatoire définie dans randomposition      
        }*/
        Vector3 randomposition = new Vector3(Random.Range(-23f, 23f), 0, 0); //spawn un animal via InvokeRepeating
        Instantiate(animalchoisi, randomposition, this.transform.rotation); //spawn un animal à une position aléatoire définie dans randomposition  
    }
}
