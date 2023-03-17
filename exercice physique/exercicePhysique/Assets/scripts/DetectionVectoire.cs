using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DetectionVectoire : MonoBehaviour
{
    [SerializeField] GameObject joueur;

    private float x ;
    private Vector3 _positionInitiale;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Objectif atteint");
        //float x = positionInitial.position.x;
        //float y = positionInitial.position.y;
        //float z = positionInitial.position.z;

        //transform.position = new Vector3(x, y, z);



        if (collision.gameObject == joueur)
        {
            joueur.transform.position = _positionInitiale;

        }
    }
}
