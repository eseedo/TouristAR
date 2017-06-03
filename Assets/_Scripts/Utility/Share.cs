using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour
{
    public static Share instance;
    
    private void Awake()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        if (instance)
        {
            instance = null;
        }
    }

    // Use this for initialization
    void Start()
    {
        
    }

}