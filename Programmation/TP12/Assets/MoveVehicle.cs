using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{
    public GestionVoiture GestionChar = new GestionVoiture();
    public float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = Vector3.zero; 
    }

    public void Move2() //Exercice 2
    {
        Vector3 vecteur = new Vector3(0, 0, 1);
        gameObject.transform.position += vecteur;
    }

    public void Move3() //Exercice 3
    {
        Vector3 vecteur = new Vector3(0, 0, 10);
        gameObject.transform.position += vecteur * Time.deltaTime;
    }

    public void Move4() //Exercice 4
    {
        Vector3 vecteur = new Vector3(0, 0, 0.05f);
        gameObject.transform.position += vecteur * vitesse;
    }

    public void Move5() //Exercice 5
    {

        if (GestionChar.roule(0.01))
        {
            Debug.Log("Roule");
            Vector3 vecteur = new Vector3(0, 0, 0.05f);
            gameObject.transform.position += vecteur * vitesse;
        }
        else
        {
            Debug.Log(" Ne Roule Pas");
        }
    }

    public void Move6() //Exercice 6
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 vecteur = new Vector3(-1, 0, 0);
            gameObject.transform.position += vecteur * vitesse * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 vecteur = new Vector3(1, 0, 0);
            gameObject.transform.position += vecteur * vitesse * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 vecteur = new Vector3(0, 0, 1);
            gameObject.transform.position += vecteur * vitesse * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 vecteur = new Vector3(0, 0, -1);
            gameObject.transform.position += vecteur * vitesse * Time.deltaTime;
        }
        
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        /* Move2(); // exercice2
         Move3(); // exercice3 
        Move4(); // exercice4 
        Move5(); //exercice5*/
        Move6(); //exercice5
    }
}
