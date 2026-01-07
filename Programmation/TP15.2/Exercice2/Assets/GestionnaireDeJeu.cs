using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireDeJeu : MonoBehaviour
{
    public GameObject obstacle;
    private ControlePersonnage personnage;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CreationObstacle), Random.Range(1f, 5f), 2f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        personnage = Player.GetComponent<ControlePersonnage>();

        if (personnage.isGameOver == true)
        {
            CancelInvoke(nameof(CreationObstacle));
        }
        
    }

    void CreationObstacle()
    {
            Instantiate(obstacle, this.transform.position, this.transform.rotation); //spawn un obstacle au niveau du spawner      
    }

}
