using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    private NavMeshAgent _nav;
    private Ray _ray;
    private RaycastHit _hit;

    private void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
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
}
