using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EtatSquelette 
{
    public EtatPoursuite(GameObject sujet, )
    public NavMeshAgent Agent
    {
        get; private set;
    }

    protected Animator ControleurAnimation
    {
        get;private set;
    }

    protected EtatSquelette(GameObject sujet)
    {
        Agent = sujet.GetComponent<NavMeshAgent>();
        ControleurAnimation = sujet.GetComponent<Animator>();
    }
    public abstract void Enter();

    public abstract void Handle (float delta );
    public abstract void leave();


    protected bool JoueurVisible()
    {
        bool visible = false;
        RaycastHit hit;

        //patch : on place les y au meme niveau pour eviter les problemes 

    }
}
