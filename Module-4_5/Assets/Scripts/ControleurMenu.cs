using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleurMenu : MonoBehaviour
{
   public void ChargerLabyrinthe(string nom)
    {
        SceneManager.LoadScene(nom);
    }

    public void Quitter()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;
#else
        application.quit();
#endif

    }
}
