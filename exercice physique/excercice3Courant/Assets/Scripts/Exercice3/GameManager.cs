using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TMP_Text textePoints;

    private int _point;
    private DetectionArrivee _zone;
    // Start is called before the first frame update
    void Start()
    {


        _zone = GameObject.Find("PlancherArrivee").GetComponent<DetectionArrivee>();
        _zone.ZoneAtteinteHandler += AjouterPoint;
        _zone.ZoneAtteinteHandler += DupliquerBalle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AjouterPoint()
    {
        
        Debug.Log("ajouter point");
    }
    private void DupliquerBalle()
    {
        GameObject nouvelleBalle = GameObject.Instantiate(balle);
        nouvelleBalle.transform.position = _positionInitiale;
        Destroy(_balleActive.GetComponent<MouvementBalle>());
        return nouvelleBalle;
        Debug.Log("DupliquerBalle");
    }

}
