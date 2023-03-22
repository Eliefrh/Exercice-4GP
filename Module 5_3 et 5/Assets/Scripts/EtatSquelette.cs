using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EtatSquelette 
{

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
}
