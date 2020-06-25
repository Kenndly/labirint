using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OtobrajenieHP : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TextMeshProUGUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI.text = HP.HealthPoint.ToString();
    }
}
