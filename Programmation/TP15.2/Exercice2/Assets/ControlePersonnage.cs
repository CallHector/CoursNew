using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonnage : MonoBehaviour
{

    public Rigidbody instanceRigidBody;
    [Range(0.1f, 50f)] public float jumpHeight;
    [Range(0.1f, 50f)] public float gravity;
    bool onGround = true;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        instanceRigidBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravity;

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {

            if (Input.GetKeyUp(KeyCode.Space) && onGround) //Jump
            {
                Jump();
            }
        }
        else
        {
            Debug.Log("Fin de la partie");
        }
    }

    void Jump() //jump
    {
        {
            instanceRigidBody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
       
            onGround = true;
           
        
    }

    private void OnCollisionExit(Collision collision)
    {
     
            onGround = false;

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            isGameOver = true;
        }
    }
}
