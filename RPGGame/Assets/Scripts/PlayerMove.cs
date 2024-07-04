using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class PlayerMove : MonoBehaviour
{
    public static bool CanMove = true;
    
    private Animator _anim;
    private NavMeshAgent _nav;
    private Ray _ray;
    private RaycastHit _hit;

    private float _x;
    private float _z;
    private float _velocitySpeed;

    private CinemachineTransposer _ct;
    [SerializeField] private CinemachineVirtualCamera _playerCam;
    private Vector3 _pos;
    private Vector3 _currPos;

    private void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
        _ct = _playerCam.GetCinemachineComponent<CinemachineTransposer>();
        _currPos = _ct.m_FollowOffset;
    }

    private void Update()
    {
        GetTouchToMove();
        MoveAnimation();
        CameraMove();
    }

    private void GetTouchToMove()
    {
        if (Input.GetMouseButtonDown(0) && CanMove)
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

    private void CameraMove()
    {
        _pos = Input.mousePosition;
        _ct.m_FollowOffset = _currPos;

        if (Input.GetMouseButton(1))
        {
            if (_pos.x != 0 || _pos.y != 0)
            {
                _currPos = _pos / 200;
            }
        }
    }
}
