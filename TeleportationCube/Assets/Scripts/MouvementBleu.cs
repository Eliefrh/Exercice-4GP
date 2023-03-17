using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementBleu : MonoBehaviour
{
    [SerializeField] private Collider colliderPlan;  // Le plan pour détecter où est le clic
    [SerializeField] private float vitesse;  // La vitesse de déplacement

    private Rigidbody _rbody;   // Le rigidbody
    private Coroutine _deplacement; // On conserve une référence de la coroutine pour pouvoir l'arêter.

    void Start()
    {
        _rbody = GetComponent<Rigidbody>();
        _deplacement = StartCoroutine(DeplacerCube(_rbody.position));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3? positionClic = Utilitaires.DeterminerClic(colliderPlan);
            if (positionClic != null)
            {
                Vector3 positionFinale = new Vector3(transform.position.x, transform.localPosition.y, positionClic.Value.z);
                StopCoroutine(_deplacement);
                _deplacement = StartCoroutine(DeplacerCube(positionFinale));
            }
        }
    }

    private IEnumerator DeplacerCube(Vector3 positionFinale)
    {

        bool termine = false;
        while (!termine)
        {
            Vector3 positionActuelle = transform.position;
            float distance = Vector3.Distance(positionActuelle, positionFinale);

            if (distance >= 0.1f)
            {
                Vector3 direction = positionFinale - positionActuelle;
                direction = direction.normalized;
                Debug.Log(direction.ToString());
                Vector3 nouvellePosition = transform.position + (direction * vitesse * Time.fixedDeltaTime);

                if (Vector3.Distance(positionActuelle, nouvellePosition) > Vector3.Distance(positionActuelle, positionFinale))
                {
                    _rbody.MovePosition(positionFinale);
                }
                else
                {
                    _rbody.MovePosition(nouvellePosition);
                }

                yield return new WaitForFixedUpdate();
            }
            else
            {
                _rbody.MovePosition(positionFinale);
                termine = true;
            }
        }
        yield return new WaitForFixedUpdate();
    }
}
