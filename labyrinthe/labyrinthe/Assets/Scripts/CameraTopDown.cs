using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Classe qui implémente une caméra de type top-down.
 *
 * Auteur: Éric Wenaas
 */
public class CameraTopDown : MonoBehaviour {

    [SerializeField] private GameObject joueur; // Le joueur que l'on suit
    [SerializeField] private float hauteur; // La hauteur de la caméra

    void Start() {
        PlacerCamera();
    }

    void LateUpdate() {
        PlacerCamera();
    }

  
    private void PlacerCamera()
    {
        float x = joueur.transform.position.x;
        float z = joueur.transform.position.z;
        transform.localPosition = new Vector3(x, hauteur, z);
    }
}
