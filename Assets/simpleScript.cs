using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
