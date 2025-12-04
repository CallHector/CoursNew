using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficheCouleur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.yellow;
    }

    public void OnCollisionStay(Collision collision)
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    public void OnCollisionExit(Collision collision)
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.white;
    }
}
