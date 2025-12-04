using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ControleJoueur : MonoBehaviour
{
    public GameObject projectile;
    Vector3 movement;
    Vector3 direction;
    float speed = 5;
    float maxOobDown = -14;
    float maxOobUp = 30;
    float maxOobLeft = -24;
    float maxOobRight = 24;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        movement = new Vector3(xAxis, 0, zAxis);
        Move();
        if (movement != Vector3.zero) //fait face à la direction
        {
            transform.forward = movement;
        }
        if (transform.position.z <= maxOobDown) //tp le joueur si out of bounds
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxOobDown);
        }
        else if (transform.position.z >= maxOobUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxOobUp);
        }
        else if (transform.position.x <= maxOobLeft)
        {
            transform.position = new Vector3(maxOobLeft, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= maxOobRight)
        {
            transform.position = new Vector3(maxOobRight, transform.position.y, transform.position.z);
        }
        Shoot();
    }

            void Move()
            {
                if (Input.GetKey(KeyCode.LeftArrow)) //fix le fait de glisser oob si deux touches en même temps
                {
                    if (transform.position.x <= maxOobLeft)
                    {

                    }
                    else
                    {
                        transform.position += movement * speed * Time.deltaTime;
                    }
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    if (transform.position.x >= maxOobRight)
                    {

                    }
                    else
                    {
                        transform.position += movement * speed * Time.deltaTime;
                    }

                }
                else if (Input.GetKey(KeyCode.UpArrow))
                {
                    if (transform.position.z >= maxOobUp)
                    {

                    }
                    else
                    {
                        transform.position += movement * speed * Time.deltaTime;
                    }
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    if (transform.position.z <= maxOobDown)
                    {

                    }
                    else
                    {
                        transform.position += movement * speed * Time.deltaTime;
                    }
                }

                else
                {

                }
            }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, this.gameObject.transform.position, this.transform.rotation);
        }
            
    }
    }

