using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    public float respawnMinAltitude;
    public float respawnMaxAltitude;
    public Vector3 startPosition;

    Vector3 direction;
    Vector3 jump;
    
    
 
    void Start()
    {
       // rigidbody = GetComponent<Rigidbody>(); //si on ne peut pas drag & drop
       startPosition = transform.position;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(new Vector3(0, respawnMinAltitude, 0), 1);
        Gizmos.DrawWireSphere(new Vector3(0, respawnMaxAltitude, 0), 1);
    }


    void Update() //appelé chaque frame
    {
        float zAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");
        
       // transform.position = transform.position + new Vector3(xAxis, 0, zAxis) * Time.deltaTime * speed; //autre manière de bouger
      
       direction = new Vector3(xAxis, 0, zAxis);
       jump = new Vector3(0, 50, 0);

        if (Input.GetKeyUp(KeyCode.Space)) //Jump
        {
            Jump();
        }

            //détecter la hauteur
            //si la hauteur < seuil
            //respawn

            if (transform.position.y <= respawnMinAltitude || transform.position.y >= respawnMaxAltitude) //Si la balle est trop haute en l'air ou trop basse
        {
            Respawn();
        }
    }
    void Respawn()
    { 
        transform.position = startPosition; //mettre la balle sur la position de départ
        rigidbody.velocity = Vector3.zero; //annule la vélocité linéaire (mais continue de rouler s'il n'y a pas de angular)
        rigidbody.angularVelocity = Vector3.zero; // permet d'annuler' complètement la vélocité)
    }

    private void FixedUpdate() //appelé par le moteur physique
    {
        rigidbody.AddForce(direction * speed, ForceMode.Force); //ajouter de la force dans une direction, sur le rigidbody
            
    }

    void Jump() //jump
    {
        rigidbody.AddForce(jump * speed, ForceMode.Force);
    }
}
