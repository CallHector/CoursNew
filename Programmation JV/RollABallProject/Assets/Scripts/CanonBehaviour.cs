using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CanonBehaviour : MonoBehaviour
{
    float lastShot;
    [SerializeField] float cooldown;
    [SerializeField] GameObject bouletPrefab;
    [SerializeField] float bouletInitSpeed;

    List<GameObject> pool = new();
    public int poolSize = 100;

    private void Awake()
    {
        InitPool();
    }

    void InitPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject g = Instantiate(bouletPrefab);
            pool.Add(g);
            g.SetActive(false);
        }
    }

    GameObject GetFree()
    {
        for (int i = 0;i < pool.Count; i++)
        {
            if (!pool[i].activeSelf)
            {
                return pool[i];
            }
        }
        //grossir la liste avec un nouvel objet
        GameObject g = Instantiate(bouletPrefab);
        pool.Add(g);
        g.SetActive(false);
        return g;
    }


    void Update()
    {
        if (Time.time >= lastShot + cooldown)
        {
            Shot();
            lastShot = Time.time;
        }
    }

    void Shot()
    {
        //faire apparaitre le boulet au bon endroit
        GameObject boulet = GetFree(); //this.transform permet d'instancier un boulet Prefab sur le pivot du canon)
        boulet.transform.position = transform.position;
        boulet.SetActive(true);
        //lui donner de la force
        boulet.GetComponent<Rigidbody>().velocity = (transform.up * bouletInitSpeed); //transform.right = vector droit du canon
    }
}
