using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouletBehaviour : MonoBehaviour
{
    [SerializeField] float duration;
    float startTime;

    private void OnEnable()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (startTime + duration <= Time.time)
        {
            DestroySelf();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroySelf();
    }

    void DestroySelf()
    {
        gameObject.SetActive(false) ;
    }
}
