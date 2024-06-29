using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursors : MonoBehaviour
{
    [SerializeField] private GameObject _cursorObject;
    [SerializeField] private Sprite _cursorBasic;
    [SerializeField] private Sprite _cursorHand;
    [SerializeField] private Image _cursorImage;
    
    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        _cursorObject.transform.position = Input.mousePosition;

        ChangeCursor();
    }

    private void ChangeCursor()
    {
        if (Input.GetMouseButton(1))
            _cursorImage.sprite = _cursorHand;
        if (Input.GetMouseButtonUp(1))
            _cursorImage.sprite = _cursorBasic;
    }
}
