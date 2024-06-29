using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    private Animator _anim;
    private NavMeshAgent _nav;
    private Ray _ray;
    private RaycastHit _hit;

    private float _x;
    private float _z;
    private float _velocitySpeed;

    private void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        GetTouchToMove();
        MoveAnimation();
    }

    private void GetTouchToMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _hit))
            {
                _nav.destination = _hit.point;
            }
        }
    }

    private void MoveAnimation()
    {
        _x = _nav.velocity.x;
        _z = _nav.velocity.z;
        _velocitySpeed = _x + _z;
        
        if (_velocitySpeed != 0)
            _anim.SetBool("Sprinting", true);
        if (_velocitySpeed == 0)
            _anim.SetBool("Sprinting", false);
    }
}
