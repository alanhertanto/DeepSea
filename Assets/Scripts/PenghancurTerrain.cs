﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenghancurTerrain : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.name == "Penghancur")
        {
            Destroy(gameObject,2f);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
