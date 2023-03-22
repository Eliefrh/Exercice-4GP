using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts
{
    public class EtatPatrouille : EtatSquelette
    {

        private Transform[] _pointsPatrouille;
        private int _indexPatrouille = 0;


        public EtatPatrouille(GameObject sujet, Transform[] pointPatrouille) : base(sujet)
        {
            _pointsPatrouille = pointPatrouille;
            _indexPatrouille = 0;
            Agent.destination = _pointsPatrouille[_indexPatrouille].position;

        }

        public override void Enter()
        {
            ControleurAnimation.SetBool("Walk", true);
        }

        public override void Handle(float delta)
        {
            if (!Agent.pathPending)
            {
                if (Agent.remainingDistance <= 0.1f)
                {
                    Agent.destination = _pointsPatrouille[_indexPatrouille].position;
                    _indexPatrouille = (_indexPatrouille + 1) % _pointsPatrouille.Length;

                }
            }
        }

        public override void leave()
        {
            ControleurAnimation.SetBool("Walk", false);

        }
    }
}
