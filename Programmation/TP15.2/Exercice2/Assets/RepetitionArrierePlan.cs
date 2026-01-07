using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetitionArrierePlan : MonoBehaviour
{
    private Vector3 positionInitiale;
    public float limite = -11f;
    // Start is called before the first frame update
    void Start()
    {
        positionInitiale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= limite)
        {
            transform.position = positionInitiale;
        }
    }
}
