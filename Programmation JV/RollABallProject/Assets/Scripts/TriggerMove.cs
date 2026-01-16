using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMove : MonoBehaviour
{
    public GameObject objectToMove;
    Vector3 originalPosition;
    Vector3 newPosition;
    bool onTrigger = false;

    private void Awake()
    {
        GameObject mover = objectToMove;
        originalPosition = mover.transform.position;
        newPosition = mover.transform.position + Vector3.up * 10;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<BallBehaviour>(out var ball))
        {
            Debug.Log("Trigger Move Activated");
            onTrigger = true;

            StartCoroutine(MoveObject());
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.TryGetComponent<BallBehaviour>(out var ball))
        {
            Debug.Log("Trigger Not Activated");
            onTrigger = false;
            StartCoroutine(ReturnObject());
        }
    }

    IEnumerator MoveObject()
    {
        float duration = 15f;
        float elapsed = 0f;

        Vector3 moverStartPosition = originalPosition;

        Vector3 moverTarget = newPosition;

        GameObject mover = objectToMove;


        while (elapsed < duration)
        {
            if (onTrigger == false)
            {
                yield break; // Exit the coroutine if still in trigger
            }
            elapsed += Time.deltaTime;

            mover.transform.position = Vector3.Lerp(moverStartPosition, moverTarget, elapsed / duration);

            yield return null;
        }
    }

    IEnumerator ReturnObject()
    {
        float duration = 15f;
        float elapsed = 0f;

        Vector3 moverStartPosition = objectToMove.transform.position;

        Vector3 moverTarget = originalPosition;

        GameObject mover = objectToMove;


        while (elapsed < duration)
        {
            if (onTrigger == true)
            {
                yield break; // Exit the coroutine if still in trigger
            }
            elapsed += Time.deltaTime;

            mover.transform.position = Vector3.Lerp(moverTarget, moverStartPosition, elapsed / duration);

            yield return null;
        }
    }
}




