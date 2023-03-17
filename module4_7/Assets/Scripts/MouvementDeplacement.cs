using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.AI;


/**
 * Classe qui d�place un objet en fonction d'un clic sur un plan
 * 
 * Auteur: �ric Wenaas
 */

public class MouvementDeplacement : MonoBehaviour
{
    //[SerializeField] private Collider colliderPlan;  // Le plan pour d�tecter o� est le clic
    //[SerializeField] private float vitesse;  // La vitesse de d�placement

    //private Rigidbody _rbody;   // Le rigidbody
    //private Coroutine _deplacement; // On conserve une r�f�rence de la coroutine pour pouvoir l'ar�ter.

    //void Start()
    //{
    //    _rbody = GetComponent<Rigidbody>();
    //    _deplacement = StartCoroutine(DeplacerCube(_rbody.position));
    //}

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Vector3? positionClic = DeterminerClic();
    //        if (positionClic != null)
    //        {
    //            Vector3 positionFinale = new Vector3(positionClic.Value.x, transform.localPosition.y, positionClic.Value.z);
    //            StopCoroutine(_deplacement);
    //            _deplacement = StartCoroutine(DeplacerCube(positionFinale));
    //        }
    //    }
    //}

    ///**
    // * M�thode qui v�rifie si le clic est sur le plan. Si le clic est � l'ext�rieur
    // * alors, on retourne null
    // */
    //private Vector3? DeterminerClic()
    //{
    //    Vector3 positionSouris = Input.mousePosition;
    //    Vector3? pointClique = null;

    //    // Trouver le lien avec la cam�ra
    //    Ray ray = Camera.main.ScreenPointToRay(positionSouris);
    //    RaycastHit hit = new RaycastHit();

    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        // V�rifier si l'objet touch� est le plan.
    //        if (hit.collider == colliderPlan)
    //        {
    //            // Le vecteur est initialise ici car le clic est sur le plan
    //            Vector3 position = hit.point;
    //            pointClique = new Vector3(position.x, position.y, position.z);
    //        }
    //    }
    //    return pointClique;
    //}


    ///**
    // * M�thode qui d�place l'objet dans la direction de la position finale.
    // * 
    // * Doit �tre d�clench� dans une coroutine.
    // */
    //private IEnumerator DeplacerCube(Vector3 positionFinale)
    //{

    //    bool termine = false;
    //    while (!termine)
    //    {
    //        Vector3 positionActuelle = transform.position;
    //        float distance = Vector3.Distance(positionActuelle, positionFinale);

    //        if (distance >= 0.1f)
    //        {
    //            Vector3 direction = positionFinale - positionActuelle;
    //            direction = direction.normalized;
    //            Debug.Log(direction.ToString());
    //            Vector3 nouvellePosition = transform.position + (direction * vitesse * Time.fixedDeltaTime);

    //            if (Vector3.Distance(positionActuelle, nouvellePosition) > Vector3.Distance(positionActuelle, positionFinale))
    //            {
    //                _rbody.MovePosition(positionFinale);
    //            }
    //            else
    //            {
    //                _rbody.MovePosition(nouvellePosition);
    //            }

    //            yield return new WaitForFixedUpdate();
    //        }
    //        else
    //        {
    //            _rbody.MovePosition(positionFinale);
    //            termine = true;
    //        }
    //    }
    //    yield return new WaitForFixedUpdate();
    //}

    [SerializeField] private Collider colliderPlan;
    private NavMeshAgent _agent;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Vector3? destination = Utilitaires.DeterminerClic(colliderPlan);
        if (Input.GetMouseButtonDown(0))
        {
            _agent.SetDestination(destination.Value);
        }
    }
}
