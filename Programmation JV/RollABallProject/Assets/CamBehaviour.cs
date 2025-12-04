using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CamBehaviour : MonoBehaviour
{
    public Vector3 distance;
    public GameObject ball;
    

    [HideInInspector] public float camangleX = 0; //HideInInspector permet de masquer une variable publique dans l'inspector
    [HideInInspector] public float camangleY = 0;
    [Range(0.1f,2)] public float camSpeed; //permet de mettre le camSpeed entre 0,1 et 2

    [SerializeField] float minRotY; //serializeField permet de modifier une variable private dans l'inspector
    [SerializeField] float maxRotY;

   
    void Update()
    {
        float deltaX = Input.GetAxis("Mouse X");
        float deltaY = Input.GetAxis("Mouse Y");
        camangleX += deltaX * camSpeed;
        camangleY += deltaY * camSpeed;
        camangleY = Mathf.Clamp(camangleY, minRotY, maxRotY);   

        Quaternion rot = Quaternion.Euler(camangleY,camangleX,0);
        Vector3 newDistance = rot * distance;

        transform.position = ball.transform.position + newDistance;
        transform.LookAt(ball.transform); //permet de centrer la rotation sur l'objet cible

        
    }
}
