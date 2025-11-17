using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GestionVoiture
{
    public double essence;
    public GestionVoiture()
    { //Constructeur
        essence = 10;
        
    }
    public double getEssence()
    {
        return essence;
    }
    public void setEssence(double valeur)
    {
        essence = valeur;
    }
    public bool roule(double consommation)
    {
        if ((getEssence() - consommation) > 0)
        {
            setEssence(getEssence() - consommation);
            return true;           
        }
        else
        {
            return false;
        }
    }
}
