using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Vector2 PositionActuelle;
    Vector2 Vitesse;
    Vector2 PositionArrivée;
    Vector2 PositionActuelle2;
    Vector2 Vitesse2;
    Vector2 PositionArrivée2;

    Vector3 PositionActuelle3D;
    Vector3 Vitesse3D;
    Vector3 PositionArrivée3D;
    Vector3 PositionActuelle3D2;
    Vector3 Vitesse3D2;
    Vector3 PositionArrivée3D2;

    // Exercice 2

    public int VitesseDéplacement;
    public int VitesseRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PositionActuelle = new Vector2(5,8);
        Vitesse = new Vector2(3,2);
        PositionArrivée = PositionActuelle + Vitesse;
        Debug.Log("Résultat: " + PositionArrivée);

        PositionActuelle2 = new Vector2(-1,-3);
        Vitesse2 = new Vector2(-2,2);
        PositionArrivée2 = PositionActuelle2 - Vitesse2;
        Debug.Log("Résultat: " + PositionArrivée2);

        PositionActuelle3D = new Vector3(-2, -1, 5);
        Vitesse3D = new Vector3(1,4,3);
        PositionArrivée3D = PositionActuelle3D + Vitesse3D;
        Debug.Log("Résultat: " + PositionArrivée3D);

        PositionActuelle3D2 = new Vector3(2, -4, 1);
        Vitesse3D2 = new Vector3(-1, -1, 3);
        PositionArrivée3D2 = PositionActuelle3D2 - Vitesse3D2;
        Debug.Log("Résultat: " + PositionArrivée3D2);

        //Exercice 2

        VitesseDéplacement = 3;
        VitesseRotation = 45;


}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * VitesseDéplacement * Time.deltaTime);
        transform.Rotate(Vector3.up * VitesseRotation * Time.deltaTime);

    }
}
