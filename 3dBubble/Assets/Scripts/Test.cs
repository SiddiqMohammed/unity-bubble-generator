using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject, 3f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destroy(gameObject);
            rb.AddForce(Vector3.up * 50f);
        }       
    }

// Destroy object after clicking with mouse
    // private void OnMouseDown() 
    // {
    //     Destroy(gameObject);
    // }
}
