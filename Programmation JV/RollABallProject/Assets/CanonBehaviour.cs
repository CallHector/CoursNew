using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBehaviour : MonoBehaviour
{
    float lastShot;
    [SerializeField] float cooldown;
    [SerializeField] GameObject bouletPrefab;
    [SerializeField] float bouletInitSpeed;


    void Update()
    {
        if (Time.time >= lastShot + cooldown)
        {
            Shot();
            lastShot = Time.time;
        }
    }

    void Shot()
    {
        //faire apparaitre le boulet au bon endroit
        GameObject boulet = Instantiate(bouletPrefab,this.transform); //this.transform permet d'instancier un boulet Prefab sur le pivot du canon)
        //lui donner de la force
        boulet.GetComponent<Rigidbody>().AddForce(transform.up * bouletInitSpeed); //transform.right = vector droit du canon
    }
}
