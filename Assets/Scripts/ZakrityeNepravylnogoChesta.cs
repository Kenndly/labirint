using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZakrityeNepravylnogoChesta : MonoBehaviour
{
    public GameObject GameObject;
    bool EstLiVnutriObject = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Vibor")
        {
            HP.HealthPoint -= 10;
            EstLiVnutriObject = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  if (EstLiVnutriObject == true)
        {
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, GameObject.transform.rotation, Time.deltaTime);
        }
        
    }
}
