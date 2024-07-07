using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    [SerializeField] private GameObject _inventoryMenu;
    [SerializeField] private GameObject _openBook;
    [SerializeField] private GameObject _closedBook;
    
    [SerializeField] private Image[] _emptySlots;
    [SerializeField] private Sprite[] _icons;
    [SerializeField] private Sprite _emptyIcon;

    public static int NewIcon = 0;
    public static bool IconUpdate = false;
    private int max;

    public static int RedMushrooms = 0;
    public static int BlueFlowers = 0;

    private void Start()
    {
        CloseMenu();
        max = _emptySlots.Length;

        RedMushrooms = 0;
        BlueFlowers = 0;
    }

    private void Update()
    {
        if (IconUpdate)
        {
            for (var i = 0; i < max; i++)
            {
                if (_emptySlots[i].sprite == _emptyIcon)
                {
                    max = i;
                    _emptySlots[i].sprite = _icons[NewIcon];
                }
            }
            StartCoroutine(Reset());
        }
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

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.1f);
        IconUpdate = false;
        max = _emptySlots.Length;
    }
}
