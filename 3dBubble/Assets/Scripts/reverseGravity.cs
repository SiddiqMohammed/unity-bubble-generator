using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseGravity : MonoBehaviour
{
    Rigidbody rb;

    public float lifeTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject, 3f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     if (lifeTime > 0)
        //     {
        //         lifeTime -= Time.deltaTime;

        //         if(lifeTime <= 0)
        //         {
        //             rb.AddForce(Vector3.up * 50f);
        //         }
        //     }

        //     // Destroy(gameObject);
        // }       
        // rb.AddForce(Vector3.up * 1f);
        // rb.AddForce(Vector3.right * 1f);
        yForce();
        xForce();
    }

    void xForce()
    {
        float randomY = Random.Range(-maxZ, maxZ);

        rb.AddForce(Vector3.right * randomY);
    }

    void yForce()
    {
        float randomX = Random.Range(-maxX, maxX);
        
        rb.AddForce(Vector3.right * randomX);
    }

}
