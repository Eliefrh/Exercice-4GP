using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HautBas : MonoBehaviour
{

    [SerializeField]
    private float vitesse;


    private bool _bouger;
    private Vector3 _incrementBase; 

    // Start is called before the first frame update
    void Start()
    {
        _incrementBase= Vector3.one;
        _bouger= true;
        Debug.Log(gameObject.transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
