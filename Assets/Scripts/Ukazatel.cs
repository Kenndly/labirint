using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ukazatel : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.transform.position, gameObject.transform.position) < 3) 
        {
            transform.Find("Fire").gameObject.SetActive(true);
            transform.Find("Fire1").gameObject.SetActive(true);
        }
    }
}
