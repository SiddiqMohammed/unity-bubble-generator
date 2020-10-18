using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public List<GameObject> newInstance;
    public Transform spawnPoint;

    public float maxX;
    public float maxZ;

    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        // SpawnBall();
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyBalls();
        }
    }

    public void SpawnBall()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, randomZ);

        newInstance.Add(Instantiate(ball, randomSpawnPos, Quaternion.identity));
        // print(newInstance.Count);
        // x++;
        print("created " + newInstance.Count);
        // Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }

    public void DestroyBalls()
    {
        // if (x > 0)
        // {
        // Destroy(newInstance[newInstance.Count]);
            // x--;
            // print("destroyed " + newInstance.Count);
        // }
        // print(x);
        newInstance.RemoveAt(newInstance.Count - 1);
    }
}
