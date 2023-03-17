using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public delegate void ZoneAtteinte();





public class DetectionArrivee : MonoBehaviour
{
    public event ZoneAtteinte ZoneAtteinteHandler;

    // [SerializeField] private TMP_Text textePoints;

    private GameObject _balleActive;
    private Vector3 _positionInitiale;

    private int _points;


    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
        _balleActive = GameObject.Find("Joueur");
        _positionInitiale= _balleActive.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnGUI()
    //{
    //    textePoints.text = _points.ToString();
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _balleActive && ZoneAtteinteHandler != null)
        {

            ZoneAtteinteHandler();
        //    _balleActive = DupliquerBalle(_balleActive);
        //    _points++;
        }
    }

    //private GameObject DupliquerBalle(GameObject balle)
    //{
        
    //    GameObject nouvelleBalle = GameObject.Instantiate(balle);
    //    nouvelleBalle.transform.position = _positionInitiale;
    //    Destroy(_balleActive.GetComponent<MouvementBalle>());
    //    return nouvelleBalle;
    //}
}
