﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NepravilnyiVibor : MonoBehaviour
{   public GameObject GameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
        if(HP.BOOL==false)
        {
            Instantiate(GameObject);
        }
    }
}
