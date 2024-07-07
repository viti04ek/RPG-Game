using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private int _number;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryItems.NewIcon = _number;
            InventoryItems.IconUpdate = true;
            Destroy(gameObject);
        }
    }
}
