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
        transform.position = Vector3.MoveTowards(gameObject.transform.position, objet_cible.transform.position , 20);


    }
}
