using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DireBonjour : MonoBehaviour
{

    [SerializeField] private TMP_InputField input;
    [SerializeField] private TMP_Text output;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DireVraimentBonjour()
    {
        string nom = input.text;
        output.text = ("Bonjour " + nom);
    }
}
