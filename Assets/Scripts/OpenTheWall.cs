using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheWall : MonoBehaviour
{
    public GameObject Zakrivashka;
   
    void Start()
    {
        //Fire = GameObject.FindGameObjectWithTag("Fire");
    }

    // Update is called once per frame
    void Update()
    {
        //print(Zakrivashka.transform.position.y);
        if (Zakrivashka.transform.position.y < 1.15)
        {              
            transform.Find("Fire").gameObject.SetActive(true);
            transform.Find("Fire1").gameObject.SetActive(true);
            transform.Find("Sound").gameObject.SetActive(true);
            gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -4f, transform.position.z), Time.deltaTime * 1.2f);
         
        }       
        
    }
}
