using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GestionnaireJeu;

public class GestionnaireJeu : MonoBehaviour
{
    public GameObject animal;

    private void Update()
    {
        CreationAnimal();  
    }

    void CreationAnimal()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(animal, this.gameObject.transform.position, this.transform.rotation);
        }
    }
}
