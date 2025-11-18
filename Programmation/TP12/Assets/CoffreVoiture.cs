using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreVoiture
{
    private float capacite;
    //définition du constructeur par défaut
    public CoffreVoiture()
    {
        Debug.Log("Le coffre de la voiture a été créé ");
        capacite = 0;
    }
    //définition du constructeur alternatif
    public CoffreVoiture(float capaciteCoffre)
    {
        capacite = capaciteCoffre;
        Debug.Log("Coffre de la voiture a été créé avec l’argument suivant : " + capaciteCoffre);
    }
    ~CoffreVoiture()
    { //définition du destructeur
        Debug.Log("Le coffre de la voiture sera maintenant détruit!");
    }

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

