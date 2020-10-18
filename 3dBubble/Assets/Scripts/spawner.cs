using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;


    public float maxX;
    public float maxZ;

    public float zPos;

    bool w;

    public float lifeTime = 1f;
    // public float birthTime = 1f; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    
        {
            w = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(w)
            {
                w = false;
            }
            else
            {
                w = true;
            }
        }
        if(w)
        {
            // if (birthTime <= 0)
            // {
                generateBubble();
            //     birthTime = 1f;
            // }

            if (lifeTime <= 0)
            {
                w = false;
                lifeTime = 1f;
            }
            
            // birthTime -= Time.deltaTime;
            lifeTime -= Time.deltaTime;
        }
    }

    void generateBubble()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, zPos, randomZ);
        Instantiate(spawnee, randomSpawnPos, Quaternion.identity);
    }
}
