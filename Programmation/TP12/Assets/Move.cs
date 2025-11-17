using System.Collections;
using System.Collections.Generic;
/*using System.Numerics; */
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vecteur = new Vector3(0, 0, 0.05f);
        gameObject.transform.position += vecteur;
    }
}
