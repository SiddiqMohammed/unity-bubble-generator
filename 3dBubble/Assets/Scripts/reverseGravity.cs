using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseGravity : MonoBehaviour
{
    Rigidbody rb;

    public float lifeTime = 3f;
    public float maxX = 5f;
    // public float maxY;


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
        //     if (lifeTime > 0)
        //     {
        //         lifeTime -= Time.deltaTime;

        //         if(lifeTime <= 0)
        //         {
        //             rb.AddForce(Vector3.up * 50f);
        //         }
        //     }

        //     // Destroy(gameObject);
            yForce();
            xForce();
        }       
        // rb.AddForce(Vector3.up * 1f);
        // rb.AddForce(Vector3.right * 1f);
        // yForce();
        // xForce();
    }

    void xForce()
    {
        float direction = Random.Range(0, 10);

        float randomX = Random.Range(-maxX, maxX);

        print(direction%2);
        
        if (direction % 2 == 0)
        {
            rb.AddForce(Vector3.right * randomX * 100);
        }
        else
        {
            rb.AddForce(Vector3.left * randomX);
        }

    }

    void yForce()
    {
        // float randomY = Random.Range(0f, 5f);
        
        rb.AddForce(Vector3.up * 100f);
    }

}
