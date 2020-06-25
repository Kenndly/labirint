using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MertviyPredmet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HP.Schet += 1;
        Destroy(gameObject);
    }
}
