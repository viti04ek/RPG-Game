using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Choose : MonoBehaviour
{
    [SerializeField] private GameObject[] _characters;
    private int _p = 0;

    public void Next()
    {
        if (_p < _characters.Length - 1)
        {
            _characters[_p].SetActive(false);
            _p++;
            _characters[_p].SetActive(true);
        }
    }
    
    public void Back()
    {
        if (_p > 0)
        {
            _characters[_p].SetActive(false);
            _p--;
            _characters[_p].SetActive(true);
        }
    }
}
