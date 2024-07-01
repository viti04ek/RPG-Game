using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _characters;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        Instantiate(_characters[SaveScript.PChar], _spawnPoint.position, _spawnPoint.rotation);
    }
}
