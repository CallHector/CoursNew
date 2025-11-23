using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleVie : MonoBehaviour
{
   CycleVie CycleVie2 = new CycleVie();
    
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("La voiture se réveille ");
    }

    void Start()
    {
        Debug.Log(" La voiture finit son paramétrage juste avant son utilisation");
    }

    ~CycleVie()
    { //définition du destructeur
        Debug.Log("La voiture est en voie de destruction");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            CycleVie2 = null;
        }
    }

 
    
}
