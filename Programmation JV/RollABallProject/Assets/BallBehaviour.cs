using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;

    Vector3 direction;
 
    void Start()
    {
       // rigidbody = GetComponent<Rigidbody>(); //si on ne peut pas drag & drop
    }

 
    void Update() //appelé chaque frame
    {
        float zAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");
       // transform.position = transform.position + new Vector3(xAxis, 0, zAxis) * Time.deltaTime * speed; //Bouger
       direction = new Vector3(xAxis, 0, zAxis);   
    }

    private void FixedUpdate() //appelé par le moteur physique
    {
        rigidbody.AddForce(direction * speed, ForceMode.Force); //ajouter de la force dans une direction, sur le rigidbody
    }
}
