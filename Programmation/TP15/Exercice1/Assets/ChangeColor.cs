using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCouleur();
    }

    void ChangeCouleur()
    {
        GameObject Cube = GameObject.Find("Cube");
        if (Cube)
        {
            Debug.Log("L’objet a été trouvé");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Renderer rend = GetComponent<Renderer>();
                rend.material.color = Color.yellow;
            }        
        }
        else
        {
            Debug.Log("L’objet n’a pas été trouvé");
        }

    }
}
