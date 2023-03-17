using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class ChargerPartie : MonoBehaviour
{

    public void loadScene(string nom )
    {
        SceneManager.LoadScene(nom);
    }
    
}
