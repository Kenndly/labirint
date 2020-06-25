using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZakrityePravylnogoChesta : MonoBehaviour
{
    public GameObject GameObject;
    bool EstLiVnutriObject = false;
    Vector3 Vector3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Vibor")
        {
            
            EstLiVnutriObject = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (EstLiVnutriObject == true)
        {
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, GameObject.transform.rotation, Time.deltaTime);
            gameObject.transform.position =  Vector3.MoveTowards(transform.position, Vector3, Time.deltaTime);
        }

    }
}
