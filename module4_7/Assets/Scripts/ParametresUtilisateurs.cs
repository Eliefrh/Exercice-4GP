using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Les paramètres sont implémentés avec un singleton
/// 
/// Auteur: Éric Wenaas
/// </summary>
public class ParametresUtilisateurs : MonoBehaviour
{
    /// <summary>
    /// L'instance statique du singleton
    /// </summary>
    private static ParametresUtilisateurs _instance ;

    /// <summary>
    /// Propriété pour obtenir l'instance
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
    /// Le facteur d'accélération
    /// </summary>
    public float FacteurCourse
    {
        set;
        get;
    }

    /// <summary>
    /// C'est un singleton. Le constructeur est privé
    /// </summary>
    //private ParametresUtilisateurs()
    //{                                              pck on peut pas faire le new behavore
    //    Vitesse = 15;
    //    FacteurCourse = 1.5f;
    //}
}
