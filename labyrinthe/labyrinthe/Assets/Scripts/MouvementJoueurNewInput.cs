﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Classe qui implémente un mouvement avec les touches de direction.
 * 
 * Auteur: Éric Wenaas
 */
public class MouvementJoueurNewInput : MonoBehaviour {

    [SerializeField] private float niveauForce;  // Le niveau de force à appliquer
    
    private Rigidbody _rbody; // Le rigidbody où on applique la force
    private float _vertical;  // La force verticale
    private float _horizontal; // La force horizontale

    void Start()
    {
        _vertical = 0.0f;
        _horizontal = 0.0f;
        _rbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();
        _horizontal = movement.x;
        _vertical = movement.y;
    }

    private void FixedUpdate()
    {
        Vector3 force = new Vector3(_horizontal, 0, _vertical);
        force *= niveauForce * Time.fixedDeltaTime;
        _rbody.AddForce(force);
    }
}
