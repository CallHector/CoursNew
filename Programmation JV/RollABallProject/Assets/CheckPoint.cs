using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        /*var ball = other.gameObject.GetComponent<BallBehaviour>(); //get le component BallBehaviour
        if (ball != null)
        {
            ball.startPosition = transform.position; //set la balle sur la position du checkpoint
        }*/

        //equivalent 
        if(other.TryGetComponent<BallBehaviour>( out var ball))
        {
            ball.startPosition = transform.position;
        }
    }
}
