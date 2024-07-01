using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour
{
    public static int PChar = 0;
    public static string PName = "player";

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
