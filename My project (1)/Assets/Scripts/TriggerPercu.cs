using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPercu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
    }

    
}
