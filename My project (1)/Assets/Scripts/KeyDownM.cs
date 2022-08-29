using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDownM : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("puertaok", true);
                      
        }
        
    }
}
