using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class CameraScript : MonoBehaviour
{
    public Vector3 Offset; //offset = distance //distance entre la caméra et la balle
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + Offset;
    }
}
