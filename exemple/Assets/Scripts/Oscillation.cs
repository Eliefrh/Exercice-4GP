using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    [SerializeField]
    private float vitesse;





    private bool _agrandir;
    private Vector3 _incrementBase;



    // Start is called before the first frame update
    void Start()
    {
        _incrementBase =  Vector3.one;
        _agrandir = true;
        Debug.Log(gameObject.transform.localScale.magnitude);
    }
        


    // Update is called once per frame
    void Update()
    {
        Vector3 incrementReel= _incrementBase * vitesse * Time.deltaTime;
        if (/*transform.localScale.magnitude <= 8*/  _agrandir)
        {
            //transform.localScale = transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);
            transform.localScale += incrementReel;
        }
        //if(/*transform.localScale.magnitude == 8*/ )
        else
        {
            //transform.localScale = transform.localScale - new Vector3(0.1f, 0.1f, 0.1f);
            transform.localScale -= incrementReel;

        }

        if (transform.localScale.magnitude >= 8.0f)
        {
            _agrandir = false;
        }

        if (transform.localScale.magnitude <= 2.0f)
        {
            _agrandir = true;
        }
    }
}
