using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CamBehaviour : MonoBehaviour
{
    public Vector3 distance;
    
 

    [HideInInspector] public float camangleX = 0; //HideInInspector permet de masquer une variable publique dans l'inspector
    [HideInInspector] public float camangleY = 0;
    [Range(0.1f,10)] public float camSpeedX; //permet de mettre le camSpeed entre 0,1 et 2
    [Range(-10f, 10)] public float camSpeedY;

    [SerializeField] float minRotY; //serializeField permet de modifier une variable private dans l'inspector
    [SerializeField] float maxRotY;

    void Start()
    {
        GameManager.instance.cam = this;
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Mouse X");
        float deltaY = Input.GetAxis("Mouse Y");
        camangleX += deltaX * camSpeedX;
        camangleY += deltaY * camSpeedY;
        camangleY = Mathf.Clamp(camangleY, minRotY, maxRotY);   

        Quaternion rot = Quaternion.Euler(camangleY,camangleX,0);
        Vector3 newDistance = rot * distance;

        transform.position = GameManager.instance.ball.transform.position + newDistance;
        transform.LookAt(GameManager.instance.ball.transform); //permet de centrer la rotation sur l'objet cible

        
    }
}
