using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regard : MonoBehaviour
{
    public GameObject objet_cible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //   transform.LookAt(objet_cible.transform); //Suit la voiture du regard
        Vector3 FollowJoueur = Vector3.MoveTowards(objet_cible.transform.position, gameObject.transform.position,  10);
        FollowJoueur.y = transform.position.y;
        FollowJoueur.x = transform.position.x;
        transform.position = FollowJoueur;

    }
}
