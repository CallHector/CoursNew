using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GestionnaireJeu;

public class GestionnaireJeu : MonoBehaviour
{
    public CoffreVoiture CoffreVoitureInstance;
    public CoffreVoiture CoffreVoitureInstance2;
    private void Awake()
    {
        CoffreVoitureInstance = new CoffreVoiture();
        CoffreVoitureInstance2 = new CoffreVoiture(5f);
    }
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.D))
        {
            CoffreVoitureInstance2 = null;
        }
    }

}
