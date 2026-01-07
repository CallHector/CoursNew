using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementObjet : MonoBehaviour
{
    [Range(0.1f, 5f)] public float vitesse;
    private ControlePersonnage personnage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        personnage = Player.GetComponent<ControlePersonnage>();

        if (personnage.isGameOver == false)
        {
            transform.Translate(Vector3.left * vitesse * Time.deltaTime);
        }
        else
        {

        }
       
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Oob")
        {
            DestroySelf();
        }
    }

    void DestroySelf()
    {
        Destroy(this.gameObject);
    }
}
