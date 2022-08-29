using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPuerta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            transform.Rotate(0, 270, 0);
            GetComponent<AudioSource>().Play();
            Destroy(this);
        }
    }
}
