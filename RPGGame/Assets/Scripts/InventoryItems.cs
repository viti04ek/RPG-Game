using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItems : MonoBehaviour
{
    [SerializeField] private GameObject _inventoryMenu;
    [SerializeField] private GameObject _openBook;
    [SerializeField] private GameObject _closedBook;

    private void Start()
    {
        CloseMenu();
    }

    public void OpenMenu()
    {
        _inventoryMenu.SetActive(true);
        _openBook.SetActive(true);
        _closedBook.SetActive(false);
        Time.timeScale = 0;
    }
    
    public void CloseMenu()
    {
        _inventoryMenu.SetActive(false);
        _openBook.SetActive(false);
        _closedBook.SetActive(true);
        Time.timeScale = 1;
    }
}
