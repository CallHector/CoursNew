using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    public Rigidbody rigidbody;

    private float deplacementAxeVertical;
    private float deplacementAxeHorizontal;
    bool powerup;
    private void Update()
    {
        deplacementAxeVertical = Input.GetAxis("Vertical");
        deplacementAxeHorizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        deplacement();
        rotation();
    }

    public void deplacement()
    {
        float vitesseDeplacement = 20f;
        Rigidbody objet_rb = GetComponent<Rigidbody>();
        Vector3 mouvement = transform.forward * deplacementAxeVertical * vitesseDeplacement * Time.deltaTime;
        objet_rb.MovePosition(objet_rb.position + mouvement);
        

        objet_rb.velocity = Vector3.zero;
        objet_rb.angularVelocity = Vector3.zero;
    }

    public void rotation()
    {
        float vitesseRotation = 30f;
        Rigidbody objet_rb = GetComponent<Rigidbody>();
        float rotation = deplacementAxeHorizontal * vitesseRotation * Time.deltaTime;
        Quaternion q_rotation = Quaternion.Euler(0f, rotation, 0f);
        objet_rb.MoveRotation(objet_rb.rotation * q_rotation);

    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("onCollisionEnter : Collision avec objet" + other.gameObject.name);

        if (other.gameObject.name.IndexOf("obstacle") >= 0 && powerup)
        {
            Destroy(other.gameObject);
            powerup = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter : Collision avec objet : " + other.gameObject.name);

        if (other.gameObject.name.IndexOf("item") >= 0)
        {
            gameObject.transform.localScale = gameObject.transform.localScale * 2f;

            Destroy(other.gameObject);
            powerup = true;
        }

    }
}
