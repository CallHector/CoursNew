using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CamBehaviour : MonoBehaviour
{
    public Vector3 distance;
    public GameObject ball;

    Vector3 lastMousePosition;
    float camangle = 0;
   [Range(0.1f,2)] public float camSpeed; //permet de mettre le camSpeed entre 0,1 et 2

    void Start()
    {
        lastMousePosition = Input.mousePosition;
    }
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 delta = mousePosition - lastMousePosition;
        camangle += delta.x * camSpeed;

        //en foncion de delta.x, on tourne la caméra autour de la balle
        camangle += delta.x;
        Quaternion rot = Quaternion.Euler(0,camangle,0);
        Vector3 newDistance = rot * distance;

        transform.position = ball.transform.position + newDistance;
        transform.LookAt(ball.transform); //permet de centrer la rotation sur l'objet cible

        lastMousePosition = mousePosition;
    }
}
