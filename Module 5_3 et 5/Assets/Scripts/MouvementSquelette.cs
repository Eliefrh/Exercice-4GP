using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouvementSquelette : MonoBehaviour
{
    [SerializeField] private Transform[] _pointsPatrouille;
    private NavMeshAgent _agent;
    private int _indexPatrouille;
    private Animator _animator;
    private EtatSquelette _etat;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _indexPatrouille = 0;
        _agent.destination = _pointsPatrouille[_indexPatrouille].position;
        _animator = GetComponent<Animator>();

        _etat = new EtatPatrouille(gameObject, _pointsPatrouille);
        _etat.Enter();

    }

    // Update is called once per frame
    void Update()
    {

        _etat.Handle(Time.deltaTime);
    //    if (!_agent.pathPending)
    //    {
    //        if (_agent.remainingDistance <= 0.1f)
    //        {
    //            _agent.destination = _pointsPatrouille[_indexPatrouille].position;
    //            _indexPatrouille = (_indexPatrouille + 1) % _pointsPatrouille.Length;
    //            _animator.SetBool("Walk",true);
    //        }
    //    }


    }
    public void ChangerEtat(EtatSquelette nouvelEtat)
    {
        _etat.leave();
        _etat = nouvelEtat;
        _etat.Enter();
    }
}
