using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private int _number;
    [SerializeField] private bool _redMushroom = false;
    [SerializeField] private bool _blueFlower = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (_redMushroom)
            {
                if (InventoryItems.RedMushrooms == 0)
                    DisplayIcons();
                InventoryItems.RedMushrooms++;
                Destroy(gameObject);
            }
            else if (_blueFlower)
            {
                if (InventoryItems.BlueFlowers == 0)
                    DisplayIcons();
                InventoryItems.BlueFlowers++;
                Destroy(gameObject);
            }
            else
            {
                DisplayIcons();
                Destroy(gameObject);
            }
        }
    }

    private void DisplayIcons()
    {
        InventoryItems.NewIcon = _number;
        InventoryItems.IconUpdate = true;
    }
}
