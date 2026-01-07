using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficheNom : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        ChangeTaille();
    }

    void ChangeTaille()
    {    
        if (Input.GetKeyDown(KeyCode.R))
        {
            Transform[] liste = gameObject.GetComponentsInChildren<Transform>();
            foreach (Transform bodypart in liste)
            {
            Debug.Log("Nom :" + bodypart.name);
            
                if (bodypart.name == "jambe")
                {
                    bodypart.localScale = bodypart.localScale * 0.75f;
                }
            }
        }
    }
}
