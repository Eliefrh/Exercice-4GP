using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Les param�tres sont impl�ment�s avec un singleton
/// 
/// Auteur: �ric Wenaas
/// </summary>
public class ParametresUtilisateurs : MonoBehaviour
{
    /// <summary>
    /// L'instance statique du singleton
    /// </summary>
    private static ParametresUtilisateurs _instance ;

    /// <summary>
    /// Propri�t� pour obtenir l'instance
    /// </summary>
    public static ParametresUtilisateurs Instance
    {
        get { return _instance;}
    }



    public void Awake()
    {

        if (Instance == null) {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }



        Vitesse = 15;
        FacteurCourse = 2;
    }
    /// <summary>
    /// La vitesse du personnage
    /// </summary>
    public int Vitesse
    {
        set;
        get;
    }

    /// <summary>
    /// Le facteur d'acc�l�ration
    /// </summary>
    public float FacteurCourse
    {
        set;
        get;
    }

    /// <summary>
    /// C'est un singleton. Le constructeur est priv�
    /// </summary>
    //private ParametresUtilisateurs()
    //{                                              pck on peut pas faire le new behavore
    //    Vitesse = 15;
    //    FacteurCourse = 1.5f;
    //}
}
