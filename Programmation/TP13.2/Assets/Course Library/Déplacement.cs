using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float vitesse = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);
    }

    void DestroySelf()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter : Collision avec objet : " + other.gameObject.name);

        if (other.gameObject.tag == "food")
        {

            Destroy(other.gameObject);
            DestroySelf();

        }

        if (other.gameObject.tag == "Oob")
        {
            DestroySelf();

        }

    }
}
